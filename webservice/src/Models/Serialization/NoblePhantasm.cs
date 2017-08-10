using System.Collections.Generic;

namespace FGOData.Models.Serialization
{
    public class NoblePhantasm
    {
        public string Name_EN { get; set; }
        public string Name_JP { get; set; }
        public string Rank { get; set; }
        public CardType Type { get; set; }
        public int HitCount { get; set; }
        public int RequiredInterlude { get; set; }
        public List<Effect> NPLevelEffects { get; set; }
        public List<Effect> OverchargeEffects { get; set; }
    }
}