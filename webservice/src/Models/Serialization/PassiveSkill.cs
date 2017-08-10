using System.Collections.Generic;

namespace FGOData.Models.Serialization
{
    public class PassiveSkill
    {
        public string Name_EN { get; set; }
        public string Name_JP { get; set; }
        public List<Effect> Effects { get; set; }
    }
}