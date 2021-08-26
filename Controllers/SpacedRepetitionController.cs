using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using day_organiser_backend.Entities;
using day_organiser_backend.Repositories;

namespace day_organiser_backend.Controllers
{
    [ApiController]
    [Route("spaced-repetition")]
    public class SpacedRepetitionController : ControllerBase
    {
        //private readonly ILogger<SpacedRepetitionController> _logger;
        //public SpacedRepetitionController(ILogger<SpacedRepetitionController> logger)
        //{
        //    _logger = logger;
        //}

        private readonly InMemSpacedRepetitionRepo repo;

        public SpacedRepetitionController()
        {
            repo = new InMemSpacedRepetitionRepo();
        }

        // GET spaced-repetition
        [HttpGet]
        public IEnumerable<SpacedRepetitionRecord> Get()
        {
            return repo.GetRecords();
        }

        // GET spaced-repetitio/{id}
        [HttpGet("{id}")]
        public SpacedRepetitionRecord Get(Guid id)
        {
            return repo.GetRecord(id);
        }
    }
}
