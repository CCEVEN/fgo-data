using FGOData.Models.Serialization;
using System.Collections.Generic;

namespace FGOData.Models.Data
{
    public class MagicResistanceA : PassiveSkill
    {
        public MagicResistanceA()
        {
            Name_EN = "Magic Resistance A";
            Name_JP = "対魔力 A";
            Effects = new List<Effect>
            {
                new Effect
                {
                    EffectType = EffectType.DebuffResist,
                    EffectValuesType = EffectValueType.Percent,
                    EffectValues = new List<float>
                    {
                        20.0f
                    }
                }
            };
        }
    }
}