using FGOData.Models.Serialization;
using System.Collections.Generic;

namespace FGOData.Models.Data
{
    public class CharismaE : ActiveSkill
    {
        public CharismaE()
        {
            Name_EN = "Charisma E";
            Name_JP = "カリスマ E";
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
                        6.0f,
                        6.6f,
                        7.2f,
                        7.8f,
                        8.4f,
                        9.0f,
                        9.6f,
                        10.2f,
                        10.8f,
                        12.0f
                    }
                }
            };
        }
    }
}
