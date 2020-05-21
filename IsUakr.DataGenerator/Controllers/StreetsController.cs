using System.Collections.Generic;
using System.Linq;
using IsUakr.DAL;
using IsUakr.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace IsUakr.DataGenerator.Controllers
{
    [Route("api/streets")]
    public class StreetsController : Controller
    {
        private readonly NpgDbContext _db;

        public StreetsController(NpgDbContext db)
        {
            _db = db;
        }

        [HttpGet()]
        public ActionResult<List<Street>> GetAllStreets()
        {
            return _db.Streets.ToList();
        }
    }
}