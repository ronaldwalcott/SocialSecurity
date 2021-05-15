using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SocialSecurity.Data;
using SocialSecurity.Data.EFClasses.Tasks;
using SocialSecurity.Domain.Actions;
using SocialSecurity.Domain.Constants;
using SocialSecurity.Domain.Models;
using SocialSecurityAPI.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialSecurityAPI.API.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PersonTasksController : ControllerBase
    {

        private readonly ILogger<PersonTasksController> _logger;
        private readonly SocialSecurityDbContext _context;
        private readonly IDateTimeUtc _dateTime;
        public PersonTasksController(SocialSecurityDbContext dbContext, ILogger<PersonTasksController> logger, IDateTimeUtc dateTimeUtc)
        {
            _context = dbContext;
            _logger = logger;
            _dateTime = dateTimeUtc;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerTask>>> Get()
        {
            UserClaim userClaim = new UserClaim();
            UserData userData = userClaim.Claims(User);

            var tableResults = await _context.PersonTasks.Select(t => new CustomerTask() 
                { 
                    ID = t.ID, 
                    Title = t.Title,
                    Status = t.Status,
                    Summary = t.Summary,
                    TaskType = t.TaskType,
                    Priority = t.Priority,
                    ReferenceEntity = t.ReferenceEntity,
                    ReferenceNumber = t.ReferenceNumber,
                    ReferenceDate = t.ReferenceDate,
                    DateToBeCompleted = t.DateToBeCompleted,
                    Colour = t.Colour,
                    User = t.User,
                    UserID = t.UserID
                }).Where(e => e.UserID == userData.UserId).ToListAsync();
            return tableResults;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerTask>> GetSingle(long id)
        {
            var tableResults = await _context.PersonTasks.FindAsync(id);
            if (tableResults == null)
            {
                return NotFound();
            }

            var customerTask = new CustomerTask();
            customerTask = CustomerTaskTransfer.GetData(tableResults);

            return customerTask;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CustomerCreateTask customerCreateTask)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            UserClaim userClaim = new UserClaim();
            UserData userData = userClaim.Claims(User);

            var table = new PersonTask();
            table = CustomerTaskTransfer.PostData(customerCreateTask);
            table.User = userData.UserName;
            table.UserID = userData.UserId;
            table.CreatedBy = userData.UserName;
            table.CreatedById = userData.UserId;
            table.CreatedDateTimeUtc = _dateTime.Now;
            table.Action = ActionRecordTypes.Created;

            try
            {
                _context.PersonTasks.Add(table);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(LoggingEvents.CustomerTask, LoggingErrorText.errorSavingTaskData, "PersonTasks", userData.UserName, ex.Message);
                throw;
            }

            return CreatedAtAction("Get", new { id = table.ID }, table);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(long id, [FromBody] CustomerTask customerTask)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != customerTask.ID)
            {
                return BadRequest();
            }

            var table = _context.PersonTasks.Find(id);
            if (table == null)
            {
                return NotFound();
            }

            UserClaim userClaim = new UserClaim();
            UserData userData = userClaim.Claims(User);

            table.ModifiedBy = userData.UserName;
            table.ModifiedById = userData.UserId;
            table.ModifiedDateTimeUtc = _dateTime.Now;
            table.Action = ActionRecordTypes.Modified;
            CustomerTaskTransfer.PutData(table, customerTask);

            try
            {
                _context.PersonTasks.Update(table);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                if (!TableExists(id))
                {
                    return NotFound();
                }
                else
                {
                    _logger.LogError(LoggingEvents.CustomerTask, LoggingErrorText.concurrencyError, "PersonTasks", userData.UserName, ex.Message);
                    throw;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(LoggingEvents.CustomerTask, LoggingErrorText.errorSavingTaskData, "PersonTasks", userData.UserName, ex.Message);
                throw;
            }
            return NoContent();
        }

        private bool TableExists(long id)
        {
            return _context.PersonTasks.Any(e => e.ID == id);
        }

    }
}
