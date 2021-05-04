using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using SocialSecurity.Data;
using SocialSecurity.Domain.ODataModels.SystemTables;
using SocialSecurity.Domain.Actions;
using System;
using System.Linq;
using System.Threading.Tasks;
using SocialSecurity.Data.EFClasses.SystemTables;
using SocialSecurityAPI.Helpers;
using SocialSecurity.Domain.Constants;
using SocialSecurity.Domain.Models;
using System.Collections.Generic;

namespace SocialSecurityAPI.API.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class TableStreetsController : ControllerBase //ODataController
    {

        private readonly ILogger<TableStreetsController> _logger;
        private readonly SocialSecurityDbContext _context;
        private readonly IDateTimeUtc _dateTime;
        public TableStreetsController(SocialSecurityDbContext dbContext, ILogger<TableStreetsController> logger, IDateTimeUtc dateTimeUtc)
        {
            _context = dbContext;
            _logger = logger;
            _dateTime = dateTimeUtc;
        }

        [EnableQuery]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GeneralTable>>> Get()
        {
            var tableResults = await _context.TableStreets.Select(t => new GeneralTable() { ID = t.ID, Code = t.Code, ShortDescription = t.ShortDescription, LongDescription = t.LongDescription }).ToListAsync();
            return tableResults;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GeneralGetTable>> Get(long id)
        {
            var tableResults = await _context.TableStreets.FindAsync(id);
            if (tableResults == null)
            {
                return NotFound();
            }

            var generalGetTable = new GeneralGetTable();

            GetGeneralTableData.GetData(tableResults, generalGetTable);

            return generalGetTable;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] GeneralPostTable generalPostTable)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            UserClaim userClaim = new UserClaim();
            UserData userData = userClaim.Claims(User);

            var table = new TableStreet();
            table.CreatedBy = userData.UserName;
            table.CreatedById = userData.UserId;
            table.CreatedDateTimeUtc = _dateTime.Now;
            table.Action = ActionRecordTypes.Created;

            PostGeneralTableData.PostData(table, generalPostTable);

            try
            {
                _context.TableStreets.Add(table);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(LoggingEvents.TableConfiguration, LoggingErrorText.errorSavingTableData, "Streets", userData.UserName, ex.Message);
                throw;
            }

            return CreatedAtAction("Get", new { id = table.ID }, table);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromODataUri] long key, [FromBody] GeneralGetTable generalGetTable)
        {
            if (key != generalGetTable.ID)
            {
                return BadRequest();
            }

            var table = _context.TableStreets.Find(key);
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
            PutGeneralTableData.PutData(table, generalGetTable);

            try
            {
                _context.TableStreets.Update(table);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                if (!TableExists(generalGetTable.ID))
                {
                    return NotFound();
                }
                else
                {
                    _logger.LogError(LoggingEvents.TableConfiguration, LoggingErrorText.concurrencyError, "Streets", userData.UserName, ex.Message);
                    throw;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(LoggingEvents.TableConfiguration, LoggingErrorText.errorSavingTableData, "Streets", userData.UserName, ex.Message);
                throw;
            }
            return NoContent();
        }

        private bool TableExists(long id)
        {
            return _context.TableStreets.Any(e => e.ID == id);
        }

    }
}
