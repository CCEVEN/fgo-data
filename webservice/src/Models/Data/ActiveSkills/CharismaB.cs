using FGOData.Models.Serialization;
using System.Collections.Generic;

namespace FGOData.Models.Data
{
    public class CharismaB : ActiveSkill
    {
        public CharismaB()
        {
            Name_EN = "Charisma B";
            Name_JP = "カリスマ B";
            Cooldown = 7;
            Effects = new List<Effect>
            {
                new Effect
                {
                    EffectType = EffectType.Attack,
                    Target = TargetType.Team,
                    Duration = 3,
                    EffectValuesType = EffectValueType.Percent,
                    EffectValues = new List<float>
                    {
                        9.0f,
                        9.9f,
                        10.8f,
                        11.7f,
                        12.6f,
                        13.5f,
                        14.4f,
                        15.3f,
                        16.2f,
                        18.0f
                    }
                }
            };
        }
    }
}