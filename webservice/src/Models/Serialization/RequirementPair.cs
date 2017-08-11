using System.Collections.Generic;

namespace FGOData.Models.Serialization
{
    public class RequirementPair<T>
    {
        public List<Requirement> Requirements { get; set; }
        public T Value { get; set; }
    }
}