using FGOData.Models.Serialization;
using System.Collections.Generic;

namespace FGOData.Models.Data
{
    public class CoreOfTheGoddessEX : PassiveSkill
    {
        public CoreOfTheGoddessEX()
        {
            Name_EN = "Core of the Goddess EX";
            Name_JP = "女神の神核 EX";
            Effects = new List<Effect>
            {
                new Effect
                {
                    EffectType = EffectType.Damage,
                    EffectValuesType = EffectValueType.Constant,
                    EffectValues = new List<float>
                    {
                        300.0f
                    }
                },
                new Effect
                {
                    EffectType = EffectType.DebuffResist,
                    EffectValuesType = EffectValueType.Percent,
                    EffectValues = new List<float>
                    {
                        30.0f
                    }
                }
            };
        }
    }
}