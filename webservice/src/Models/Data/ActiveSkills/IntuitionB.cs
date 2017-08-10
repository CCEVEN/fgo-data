using FGOData.Models.Serialization;
using System.Collections.Generic;

namespace FGOData.Models.Data
{
    public class IntuitionB : ActiveSkill
    {
        public IntuitionB()
        {
            Name_EN = "Intuition B";
            Name_JP = "直感 B";
            Cooldown = 7;
            RequiredAscension = 1;
            Effects = new List<Effect> {
                new Effect()
                {
                    EffectType = EffectType.Stars,
                    Target = TargetType.Self,
                    Duration = 1,
                    EffectValuesType = EffectValueType.Constant,
                    EffectValues = new List<float>
                    {
                        4,
                        5,
                        6,
                        7,
                        8,
                        9,
                        10,
                        11,
                        12,
                        14
                    }
                }
            };
        }
    }
}
