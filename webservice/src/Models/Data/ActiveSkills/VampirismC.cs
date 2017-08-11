using FGOData.Models.Serialization;
using System.Collections.Generic;

namespace FGOData.Models.Data
{
    public class VampirismC : ActiveSkill
    {
        public VampirismC()
        {
            Name_EN = "Vampirism C";
            Name_JP = "吸血 C";
            Cooldown = 8;
            Effects = new List<Effect>
            {
                new Effect
                {
                    Requirements = new List<Requirement>
                    {
                        new Requirement
                        (
                            RequirementType.PercentChance,
                            string.Join(", ", new float[]
                            {
                                60.0f,
                                62.0f,
                                64.0f,
                                66.0f,
                                68.0f,
                                70.0f,
                                72.0f,
                                74.0f,
                                78.0f,
                                80.0f
                            })
                        )
                    },
                    EffectType = EffectType.NPGauge,
                    Target = TargetType.EnemyTarget,
                    EffectValuesType = EffectValueType.Constant,
                    EffectValues = new List<float>
                    {
                        1.0f
                    }
                },
                new Effect
                {
                    EffectType = EffectType.NPGauge,
                    Target = TargetType.Self,
                    EffectValuesType = EffectValueType.Percent,
                    EffectValues = new List<float>
                    {
                        18.0f,
                        18.9f,
                        19.8f,
                        20.7f,
                        21.6f,
                        22.5f,
                        23.4f,
                        24.3f,
                        25.2f,
                        27.0f
                    }
                }
            };
        }
    }
}