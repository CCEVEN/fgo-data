namespace FGOData.Models.Serialization
{
    public class Requirement
    {
        public RequirementType Type { get; set; }
        public string Value { get; set; }

        public Requirement(RequirementType type, object value)
        {
            Type = type;
            Value = value.ToString();
        }
    }
}