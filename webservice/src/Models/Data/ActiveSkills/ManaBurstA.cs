using FGOData.Models.Serialization;
using System.Collections.Generic;

namespace FGOData.Models.Data
{
    public class ManaBurstA : ActiveSkill
    {
        public ManaBurstA()
        {
            Name_EN = "Mana Burst A";
            Name_JP = "魔力放出 A";
            Cooldown = 7;
            Effects = new List<Effect>
            {
                new Effect
                {
                    EffectType = EffectType.Buster,
                    Target = TargetType.Self,
                    Duration = 1,
                    EffectValuesType = EffectValueType.Percent,
                    EffectValues = new List<float>
                    {
                        30.0f,
                        32.0f,
                        34.0f,
                        36.0f,
                        38.0f,
                        40.0f,
                        42.0f,
                        44.0f,
                        46.0f,
                        50.0f
                    }
                }
            };
        }
    }
}