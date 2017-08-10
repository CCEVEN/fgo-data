using System.Collections.Generic;

namespace FGOData.Models.Serialization
{
    public class ActiveSkill
    {
        public string Name_EN { get; set; }
        public string Name_JP { get; set; }
        public int Cooldown { get; set; }
        public int RequiredAscension { get; set; }
        public int RequiredInterlude { get; set; }
        public List<Effect> Effects { get; set; }
    }
}