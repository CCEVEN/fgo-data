using FGOData.Models.Serialization;
using System.Collections.Generic;

namespace FGOData.Models.Data
{
    public class MagicResistanceB : PassiveSkill
    {
        public MagicResistanceB()
        {
            Name_EN = "Magic Resistance B";
            Name_JP = "対魔力 B";
            Effects = new List<Effect>
            {
                new Effect()
                {
                    EffectType = EffectType.DebuffResist,
                    EffectValuesType = EffectValueType.Percent,
                    EffectValues = new List<float>
                    {
                        17.5f
                    }
                }
            };
        }
    }
}
