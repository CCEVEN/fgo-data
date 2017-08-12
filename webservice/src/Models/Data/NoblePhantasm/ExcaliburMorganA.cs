using FGOData.Models.Serialization;
using System.Collections.Generic;

namespace FGOData.Models.Data
{
    public class ExcaliburMorganA : NoblePhantasm
    {
        public ExcaliburMorganA()
        {
            Name_EN = "Excalibur Morgan";
            Name_JP = "エクスカリバー・モルガン";
            Rank = "A++";
            Type = CardType.Buster;
            HitCount = 3;
            NPLevelEffects = new List<Effect> {
                new Effect()
                {
                    EffectType = EffectType.Damage,
                    Target = TargetType.EnemyTeam,
                    Duration = 1,
                    EffectValuesType = EffectValueType.Percent,
                    EffectValues = new List<float>
                    {
                        450.0f,
                        550.0f,
                        600.0f,
                        625.0f,
                        650.0f
                    }
                }
            };
            OverchargeEffects = new List<Effect> {
                new Effect()
                {
                    EffectType = EffectType.NPGauge,
                    Target = TargetType.Self,
                    EffectValuesType = EffectValueType.Percent,
                    EffectValues = new List<float>
                    {
                        10.0f,
                        15.0f,
                        20.0f,
                        25.0f,
                        30.0f
                    }
                }
            };

        }

    }
}
