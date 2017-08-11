using System.Collections.Generic;

namespace FGOData.Models.Serialization
{
    public class Effect
    {
        public List<Requirement> Requirements { get; set; }
        public EffectType EffectType { get; set; }
        public TargetType Target { get; set; }
        public int Duration { get; set; }
        public int HitCount { get; set; }
        public EffectValueType EffectValuesType { get; set; }
        public List<float> EffectValues { get; set; }
    }
}