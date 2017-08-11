using FGOData.Models.Serialization;
using System.Collections.Generic;

namespace FGOData.Models.Data
{
    public class PresenceConcealmentA2 : PassiveSkill
    {
        public PresenceConcealmentA2()
        {
            Name_EN = "Presence Concealment A+";
            Name_JP = "気配遮断 A+";
            Effects = new List<Effect>
            {
                new Effect
                {
                    EffectType = EffectType.StarGen,
                    EffectValuesType = EffectValueType.Percent,
                    EffectValues = new List<float>
                    {
                        10.5f
                    }
                }
            };
        }
    }
}