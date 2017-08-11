using FGOData.Models.Serialization;
using System.Collections.Generic;

namespace FGOData.Models.Data
{
    public class WhimOfTheGoddessA : ActiveSkill
    {
        public WhimOfTheGoddessA()
        {
            Name_EN = "Whim of the Goddess A";
            Name_JP = "女神のきまぐれ A";
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
                        10.0f,
                        11.0f,
                        12.0f,
                        13.0f,
                        14.0f,
                        15.0f,
                        16.0f,
                        17.0f,
                        18.0f,
                        20.0f
                    }
                },
                new Effect
                {
                    Requirements = new List<Requirement>
                    {
                        new Requirement(RequirementType.Trait, TraitType.Divine)
                    },
                    EffectType = EffectType.Attack,
                    Target = TargetType.Team,
                    Duration = 3,
                    EffectValuesType = EffectValueType.Percent,
                    EffectValues = new List<float>
                    {
                        10.0f,
                        11.0f,
                        12.0f,
                        13.0f,
                        14.0f,
                        15.0f,
                        16.0f,
                        17.0f,
                        18.0f,
                        20.0f
                    }
                }
            };
        }
    }
}