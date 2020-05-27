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
    [Route("/v1")]
    [ApiController]
    public class StringController : ControllerBase
    {
        private readonly IStringServices _services;
        private readonly IUnitOfWork _unit;
        public StringController(IStringServices services, IUnitOfWork unit)
        {
            _services = services;
            _unit = unit;
        }


        [HttpPost]
        [Route("Invert/{words}")]
        public ActionResult<string> InvertWord(string words)
        {
            var invertedString = _services.InvertString(words);
            _unit.StringRepo.SaveStringInversionToDatabase(words, invertedString);

            return invertedString;
        }

        [HttpPost]
        [Route("RemoveWhiteSpace/{message}")]
        public ActionResult<string> RemoveWhiteSpaceWord(string message)
        {
            var modifiedString = _services.RemoveWhite(message);
            _unit.StringRepo.SaveRemoveWhiteSpaceToDatabase(message, modifiedString);
            return modifiedString;
        }
    }
}