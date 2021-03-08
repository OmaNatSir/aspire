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
        public IActionResult GetDatabaseDetails(string databaseName)
        {
            var database = _dbContext.DldDatabase.Where(dbs => dbs.DatabaseName == databaseName).Single();

            return View((DldDatabase)database);
        }


        //TEST: /database/adventureworkslt2017/table
        [HttpGet("database/{databaseName}/table")]
        public IActionResult GetTableList(string databaseName)
        {
            List<DldTable> listTable = _dbContext.DldTable.Include(table => table.DldSchema)
                                         .ThenInclude(schema => schema.DldDatabase)
                                         .Where(tbl => tbl.DldSchema.DldDatabase.DatabaseName == databaseName)
                                         .ToList();

            return View(listTable);
        }

        //TEST: /database/adventureworkslt2017/schema/saleslt/table/address
        [HttpGet("database/{databaseName}/schema/{schemaName}/table/{tableName}")]
        public IActionResult GetColumnList(string databaseName, string schemaName, string tableName)
        {
            List<DldColumn> listColumn = _dbContext.DldColumn.Include(clm => clm.DldTable)
                                        .ThenInclude(tbl => tbl.DldSchema)
                                        .ThenInclude(scm => scm.DldDatabase)
                                        .Where(clm => clm.DldTable.DldSchema.DldDatabase.DatabaseName == databaseName)
                                        .Where(clm => clm.DldTable.DldSchema.SchemaName == schemaName)
                                        .Where(clm => clm.DldTable.TableName == tableName)
                                        .ToList();

            return View(listColumn);
        }
    }
}