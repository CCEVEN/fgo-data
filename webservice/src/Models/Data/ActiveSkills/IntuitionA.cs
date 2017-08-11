using FGOData.Models.Serialization;
using System.Collections.Generic;

namespace FGOData.Models.Data
{
    public class IntuitionA : ActiveSkill
    {
        public IntuitionA()
        {
            Name_EN = "Intuition A";
            Name_JP = "直感 A";
            Cooldown = 7;
            Effects = new List<Effect>
            {
                new Effect
                {
                    EffectType = EffectType.Stars,
                    Target = TargetType.Self,
                    EffectValuesType = EffectValueType.Constant,
                    EffectValues = new List<float>
                    {
                        5,
                        6,
                        7,
                        8,
                        9,
                        10,
                        11,
                        12,
                        13,
                        15
                    }
                }
            };
        }
    }
}