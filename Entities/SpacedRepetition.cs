using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace day_organiser_backend.Entities
{
    public enum LearningProficiency
    {
        None = 0,
        Low = 1,
        Medium = 2,
        High = 3
    }

    public record SpacedRepetitionLearningRecord
    {
        public Guid Id { get; init; }
        public DateTimeOffset Date { get; init; }

        public LearningProficiency Proficiency { get; set; }
    }

    public record SpacedRepetitionRecord
    {
        public Guid Id { get; init; }
        public string Topic { get; init; }

        public IEnumerable<SpacedRepetitionLearningRecord> LearningHistory { get; set; }
    }
}
