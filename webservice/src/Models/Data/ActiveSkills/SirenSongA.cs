using FGOData.Models.Serialization;
using System.Collections.Generic;

namespace FGOData.Models.Data
{
    public class SirenSongA : ActiveSkill
    {
        public SirenSongA()
        {
            Name_EN = "Siren Song A";
            Name_JP = "魅惑の美声 A";
            Cooldown = 9;
            Effects = new List<Effect>
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
                        70.0f,
                        73.0f,
                        76.0f,
                        79.0f,
                        82.0f,
                        85.0f,
                        88.0f,
                        91.0f,
                        94.0f,
                        100.0f
                    }
                }
            };
        }
    }
}