using FGOData.Models.Serialization;
using System.Collections.Generic;

namespace FGOData.Models.Data
{
    public class ExcaliburA2 : NoblePhantasm
    {
        public ExcaliburA2()
        {
            Name_EN = "Excalibur";
            Name_JP = "エクスカリバー";
            Rank = "A++";
            Type = CardType.Buster;
            HitCount = 1;
            NPLevelEffects = new List<Effect>
            {
                new Effect
                {
                    EffectType = EffectType.Damage,
                    Target = TargetType.EnemyTeam,
                    Duration = 1,
                    EffectValuesType = EffectValueType.Percent,
                    EffectValues = new List<float>
                    {
                        400.0f,
                        500.0f,
                        550.0f,
                        575.0f,
                        600.0f
                    }
                }
            };
            OverchargeEffects = new List<Effect>
            {
                new Effect
                {
                    EffectType = EffectType.NPGauge,
                    Target = TargetType.Self,
                    Duration = 1,
                    EffectValuesType = EffectValueType.Percent,
                    EffectValues = new List<float>
                    {
                        20.0f,
                        27.5f,
                        35.0f,
                        42.5f,
                        50.0f
                    }
                }
            };

        }

    }
}