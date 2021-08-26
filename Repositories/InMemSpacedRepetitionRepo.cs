using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using day_organiser_backend.Entities;

namespace day_organiser_backend.Repositories
{
    public class InMemSpacedRepetitionRepo
    {

        private readonly List<SpacedRepetitionRecord> records = new()
        {
            new SpacedRepetitionRecord
            {
                Id = Guid.NewGuid(),
                Topic = "RESTful APIs",
                LearningHistory = new SpacedRepetitionLearningRecord[]
            {
                new SpacedRepetitionLearningRecord {
                    Id = Guid.NewGuid(),
                    Date = DateTimeOffset.UtcNow,
                    Proficiency = LearningProficiency.Low
                }
            },
            }
        };

        public IEnumerable<SpacedRepetitionRecord> GetRecords()
        {
            return records;
        }

        public SpacedRepetitionRecord GetRecord(Guid id)
        {
            return records.Where(item => item.Id == id).SingleOrDefault();
        }

    }
}
