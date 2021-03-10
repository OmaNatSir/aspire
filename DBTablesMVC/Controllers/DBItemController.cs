using DBTablesMVC.Data;
using DBTablesMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBTablesMVC.Controllers
{
    public class DBItemController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public DBItemController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //TEST: /database/AdventureWorksLT2017	
        [HttpGet("database/{databaseName}")]
        public async Task<IActionResult> GetDatabaseDetails(string databaseName)
        {
            try
            {
                var database = await _dbContext.DldDatabase.Where(dbs => dbs.DatabaseName == databaseName).SingleAsync();

                ViewBag.ListTable = await GetTableList(databaseName);
                ViewBag.DatabaseName = database.DatabaseName;

                return View((DldDatabase)database);
            }
            catch
            {
                return Content("Error: there is no database with such name");
            }

        }

        //TEST: /database/adventureworkslt2017/schema/saleslt/table/address
        [HttpGet("database/{databaseName}/schema/{schemaName}/table/{tableName}")]
        public async Task<IActionResult> GetColumnList(string databaseName, string schemaName, string tableName)
        {
            var listColumn = await GetColumnListDetails(databaseName, schemaName, tableName);

            ViewBag.ListTable = await GetTableList(databaseName);
            ViewBag.TableName = listColumn[0].DldTable.TableName;   //Ensuring capital letters in {tableName}
            ViewBag.DatabaseName = listColumn[0].DldTable.DldSchema.DldDatabase.DatabaseName; // in {databaseName}

            return View(listColumn);
        }

        private async Task<List<DldTable>> GetTableList(string databaseName)
        {
            return await _dbContext.DldTable.Include(table => table.DldSchema)
                                         .ThenInclude(schema => schema.DldDatabase)
                                         .Where(tbl => tbl.DldSchema.DldDatabase.DatabaseName == databaseName)
                                         .ToListAsync();
        }

        private async Task<List<DldColumn>> GetColumnListDetails(string databaseName, string schemaName, string tableName)
        {
            return await _dbContext.DldColumn.Include(clm => clm.DldTable)
                                        .ThenInclude(tbl => tbl.DldSchema)
                                        .ThenInclude(scm => scm.DldDatabase)
                                        .Where(clm => clm.DldTable.DldSchema.DldDatabase.DatabaseName == databaseName)
                                        .Where(clm => clm.DldTable.DldSchema.SchemaName == schemaName)
                                        .Where(clm => clm.DldTable.TableName == tableName)
                                        .ToListAsync();
        }
    }
}