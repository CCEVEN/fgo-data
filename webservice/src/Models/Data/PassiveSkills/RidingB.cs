using FGOData.Models.Serialization;
using System.Collections.Generic;

namespace FGOData.Models.Data
{
    public class RidingB : PassiveSkill
    {
        public RidingB()
        {
            Name_EN = "Riding B";
            Name_JP = "騎乗 B";
            Effects = new List<Effect>
            {
                new Effect
                {
                    EffectType = EffectType.Quick,
                    EffectValuesType = EffectValueType.Percent,
                    EffectValues = new List<float>
                    {
                        8.0f
                    }
                }
            };
        }
    }
}