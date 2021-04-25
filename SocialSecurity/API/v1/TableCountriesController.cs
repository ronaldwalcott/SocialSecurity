using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using SocialSecurity.Data;
using SocialSecurity.Domain.ODataModels.SystemTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialSecurityAPI.API.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class TableCountriesController : ControllerBase //ODataController
    {

        private readonly ILogger<TableCountriesController> _logger;
        private readonly SocialSecurityDbContext _context;

        public TableCountriesController(SocialSecurityDbContext dbContext, ILogger<TableCountriesController> logger )
        {
            _context = dbContext;
            _logger = logger;
        }

        [EnableQuery]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GeneralTable>>> Get()
        {
            var tableResults = await _context.TableCountries.Select(t => new GeneralTable() { ID = t.ID }).ToListAsync();
            return tableResults;
        }

    }
}
