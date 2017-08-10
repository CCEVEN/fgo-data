using System.Collections.Generic;

namespace FGOData.Models.Serialization
{
    public class Effect
    {
        public EffectType EffectType { get; set; }
        public TargetType Target { get; set; }
        public GenderType? RequiredGender { get; set; }
        public AttributeType? RequiredAttribute { get; set; }
        public TraitType? RequiredTrait { get; set; }
        public string RequiredTerrain { get; set; }
        public float? RequiredNPGauge { get; set; }
        public float? PercentChance { get; set; }
        public int? Duration { get; set; }
        public int? Hits { get; set; }
        public int? Delay { get; set; }
        public EffectValueType EffectValuesType { get; set; }
        public List<float> EffectValues { get; set; }
    }
}