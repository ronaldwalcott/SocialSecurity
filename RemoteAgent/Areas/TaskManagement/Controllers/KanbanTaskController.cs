using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using RemoteAgent.Areas.Appointments.Models.Kanban;
using RemoteAgent.Constants;
using RemoteAgent.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RemoteAgent.Areas.TaskManagement.Controllers
{
    [Area(AreaNames.KanbanTasksArea)]
    public class KanbanTaskController : Controller
    {
        private readonly ILogger<KanbanTaskController> _logger;
        private readonly IHttpClient _httpClient;
        private readonly IHttpOdataClient _httpOdataClient;
        private readonly IConfiguration _configuration;

        public KanbanTaskController(IHttpClient httpClient, IHttpOdataClient httpOdataClient, IConfiguration configuration, ILogger<KanbanTaskController> logger)
        {
            _httpClient = httpClient;
            _httpOdataClient = httpOdataClient;
            _configuration = configuration;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var taskPriorities = _httpOdataClient.GetClient().For<TableTaskPriorities>().FindEntriesAsync().Result;
            var taskReferenceTypes = _httpOdataClient.GetClient().For<TableTaskReferenceTypes>().FindEntriesAsync().Result;
            var taskStatuses = _httpOdataClient.GetClient().For<TableTaskStatuses>().FindEntriesAsync().Result;
            var taskTypes = _httpOdataClient.GetClient().For<TableTaskTypes>().FindEntriesAsync().Result;

            ViewBag.Priorities = taskPriorities.Select(d => d.ShortDescription).ToList();
            ViewBag.ReferenceTypes = taskReferenceTypes.Select(d => d.ShortDescription).ToList();
            ViewBag.Statuses = taskStatuses.Select(d => d.ShortDescription).ToList();
            ViewBag.TaskTypes = taskTypes.Select(d => d.ShortDescription).ToList();

            ViewBag.Area = AreaNames.KanbanTasksArea;

            return View();
        }

        [HttpPost]
        public async Task<List<KanbanCard>> LoadCard()
        {
            List<KanbanCard> kanbanCards = new List<KanbanCard>();
            var httpClient = await _httpClient.GetClient();
            var response = await httpClient.GetAsync(_configuration["ApiResourceBaseUrls:Api"] + "/api/v1/PersonTasks").ConfigureAwait(false);

            if (response.IsSuccessStatusCode)
            {
                var apiResponse = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                kanbanCards = JsonConvert.DeserializeObject<List<KanbanCard>>(apiResponse);
            }

            return kanbanCards;
        }

        [HttpPost]
        public async Task<List<KanbanCard>> UpdateCard([FromBody] EditParams param)
        {
            var httpClient = await _httpClient.GetClient();

            // this block of code will execute while inserting the new cards
            if (param.action == "insert" || (param.action == "batch" && param.added.Count > 0))
            {
                var value = (param.action == "insert") ? param.value : param.added[0];
                //int intMax = _context.KanbanCards.ToList().Count > 0 ? _context.KanbanCards.ToList().Max(p => p.Id) : 1;
                KanbanCard card = new KanbanCard()
                {
                    Title = value.Title,
                    Status = value.Status,
                    Summary = value.Summary,
                    TaskType = value.TaskType,
                    Priority = value.Priority,
                    ReferenceEntity = value.ReferenceEntity,
                    ReferenceNumber = value.ReferenceNumber,
                    ReferenceDate = value.ReferenceDate,
                    DateToBeCompleted = value.DateToBeCompleted,
                    Colour = value.Colour
                };
                if (card.Priority == "High")
                {
                    card.Colour = getColour("red");
                }
                else if (card.Priority == "Medium")
                {
                    card.Colour = getColour("yellow");
                }
                else if (card.Priority == "Low")
                {
                    card.Colour = getColour("green");
                }

                StringContent content = new StringContent(JsonConvert.SerializeObject(card), Encoding.UTF8, "application/json");
                var insertResponse = await httpClient.PostAsync(_configuration["ApiResourceBaseUrls:Api"] + "/api/v1/PersonTasks", content);

                if (!insertResponse.IsSuccessStatusCode)
                    throw new Exception(insertResponse.ToString());
            }
            // this block of code will execute while updating the existing cards
            if (param.action == "update" || (param.action == "batch" && param.changed.Count > 0))
            {
                KanbanCard value = (param.action == "update") ? param.value : param.changed[0];

                KanbanCard updateCard = new KanbanCard();

                var cardExistResponse = await httpClient.GetAsync(_configuration["ApiResourceBaseUrls:Api"] + "/api/v1/PersonTasks/" + value.ID).ConfigureAwait(false);

                if (cardExistResponse.IsSuccessStatusCode)
                {
                    var apiResponse = await cardExistResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    updateCard = JsonConvert.DeserializeObject<KanbanCard>(apiResponse);
                }

                //IQueryable<KanbanCard> filterData = _context.KanbanCards.Where(c => c.Id == Convert.ToInt32(value.Id));
                if (updateCard.ID > 0)
                {
                    //KanbanCard card = _context.KanbanCards.Single(A => A.Id == Convert.ToInt32(value.Id));
                    updateCard.Title = value.Title;
                    updateCard.Status = value.Status;
                    updateCard.Summary = value.Summary;
                    updateCard.TaskType = value.TaskType;
                    updateCard.Priority = value.Priority;
                    updateCard.ReferenceEntity = value.ReferenceEntity;
                    updateCard.ReferenceNumber = value.ReferenceNumber;
                    updateCard.ReferenceDate = value.ReferenceDate;
                    updateCard.DateToBeCompleted = value.DateToBeCompleted;
                    updateCard.Colour = value.Colour;
                    updateCard.User = value.User;
                    updateCard.UserID = value.UserID;

                    if (updateCard.Priority == "High")
                    {
                        updateCard.Colour = getColour("red");
                    }
                    else if (updateCard.Priority == "Medium")
                    {
                        updateCard.Colour = getColour("yellow");
                    }
                    else if (updateCard.Priority == "Low")
                    {
                        updateCard.Colour = getColour("green");
                    }


                    StringContent content = new StringContent(JsonConvert.SerializeObject(updateCard), Encoding.UTF8, "application/json");
                    var updateResponse = await httpClient.PutAsync(_configuration["ApiResourceBaseUrls:Api"] + "/api/v1/PersonTasks/" + updateCard.ID, content);

                    if (!updateResponse.IsSuccessStatusCode)
                        throw new Exception(updateResponse.ToString());

                }
                //                _context.SaveChanges();
            }
            // this block of code will execute while deleting the existing cards
            if (param.action == "remove" || (param.action == "batch" && param.deleted.Count > 0))
            {
                if (param.action == "remove")
                {
                    long key = Convert.ToInt64(param.key);

                    KanbanCard deleteCard = new KanbanCard();
                    var deleteResponse = await httpClient.DeleteAsync(_configuration["ApiResourceBaseUrls:Api"] + "/api/v1/PersonTasks/" + key).ConfigureAwait(false);
                    if (!deleteResponse.IsSuccessStatusCode)
                        throw new Exception(deleteResponse.ToString());

                }
                else
                {
                    foreach (KanbanCard cards in param.deleted)
                    {
                        KanbanCard deleteCard = new KanbanCard();
                        var deleteResponse = await httpClient.DeleteAsync(_configuration["ApiResourceBaseUrls:Api"] + "/api/v1/PersonTasks/" + cards.ID).ConfigureAwait(false);
                        if (!deleteResponse.IsSuccessStatusCode)
                            throw new Exception(deleteResponse.ToString());

                    }
                }
                //_context.SaveChanges();
            }

            List<KanbanCard> kanbanCards = new List<KanbanCard>();
            var response = await httpClient.GetAsync(_configuration["ApiResourceBaseUrls:Api"] + "/api/v1/PersonTasks").ConfigureAwait(false);

            if (response.IsSuccessStatusCode)
            {
                var apiResponse = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                kanbanCards = JsonConvert.DeserializeObject<List<KanbanCard>>(apiResponse);
            }

            return kanbanCards;

            //return _context.KanbanCards.ToList();
        }

        private string getColour(string colour)
        {
            Hashtable colourValue = new Hashtable();
            colourValue.Add("blue", "#007bff");
            colourValue.Add("purple", "#6f42c1");
            colourValue.Add("red", "#dc3545");
            colourValue.Add("orange", "#fd7e14");
            colourValue.Add("yellow", "#ffc107");
            colourValue.Add("green", "#28a745");

            return (string)colourValue[colour];

        }

        public class EditParams
        {
            public string key { get; set; }
            public string action { get; set; }
            public string keyColumn { get; set; }
            public string table { get; set; }

            public List<KanbanCard> added { get; set; }
            public List<KanbanCard> changed { get; set; }
            public List<KanbanCard> deleted { get; set; }
            public KanbanCard value { get; set; }
        }

    }
}
