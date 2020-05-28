using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Challenges.Data;
using Challenges.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Challenges.Controllers
{
    [Route("v1/")]
    [ApiController]
    public class SortingController : ControllerBase
    {
        private readonly ISortingServices _services;
        private readonly IUnitOfWork _unit;

        public SortingController(ISortingServices services, IUnitOfWork unit)
        {
            _services = services;
            _unit = unit;
        }

        [HttpPost]
        [Route("Sort")]
        public ActionResult<List<char>> BubbleSort(IEnumerable<char> collection)
        {
            List<char> asList = collection.ToList();
            


            var sorted = _services.Sort(asList);
            _unit.SortingRepo.SaveSortingToDatabase(asList, sorted);
            return sorted;
        }
    }
}