using FGOData.Models.Serialization;
using System.Collections.Generic;

namespace FGOData.Models.Data
{
    public class SmileOfTheStheno : NoblePhantasm
    {
        public SmileOfTheStheno()
        {
            Name_EN = "Smile of the Stheno";
            Name_JP = "スマイル・オブ・ザ・ステンノ";
            Rank = "B";
            Type = CardType.Buster;
            HitCount = 0;
            NPLevelEffects = new List<Effect>
            {
                new Effect
                {
                    EffectType = EffectType.Defence,
                    Target = TargetType.EnemyTarget,
                    Duration = 3,
                    EffectValuesType = EffectValueType.Percent,
                    EffectValues = new List<float>
                    {
                        -20.0f
                    }
                },
                new Effect
                {
                    Requirements = new List<Requirement>
                    {
                        new Requirement(RequirementType.Gender, GenderType.Male)
                    },
                    EffectType = EffectType.Death,
                    Target = TargetType.EnemyTarget,
                    EffectValuesType = EffectValueType.Percent,
                    EffectValues = new List<float>
                    {
                        100.0f,
                        125.0f,
                        137.5f,
                        143.8f,
                        150.0f
                    }
                }
            };
            OverchargeEffects = new List<Effect>
            {
                new Effect
                {
                    Requirements = new List<Requirement>
                    {
                        new Requirement(RequirementType.Gender, GenderType.Male)
                    },
                    EffectType = EffectType.Charm,
                    Target = TargetType.EnemyTarget,
                    Duration = 1,
                    EffectValuesType = EffectValueType.Percent,
                    EffectValues = new List<float>
                    {
                        100.0f,
                        125.0f,
                        150.0f,
                        175.0f,
                        200.0f
                    }
                }
            };

        }

    }
}