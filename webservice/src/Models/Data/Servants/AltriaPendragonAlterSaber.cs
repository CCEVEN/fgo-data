using FGOData.Models.Serialization;
using System.Collections.Generic;

namespace FGOData.Models.Data
{
    public class AltriaPendragonAlterSaber : Servant
    {
        public AltriaPendragonAlterSaber()
        {
            Id = 3;
            Name_EN = "Altria Pendragon (Alter)";
            Name_JP = "アルトリア・ペンドラゴン［オルタ］";
            Class = ClassType.Saber;
            Cost = 12;
            Rarity = 4;
            Gender = GenderType.Female;
            Attribute = AttributeType.Man;
            Traits = new List<TraitType>
            {
                TraitType.Arthur,
                TraitType.Dragon,
                TraitType.Evil
                TraitType.Humanoid,
                TraitType.Saberface,
                TraitType.Servant,
                TraitType.WeakToEnumaElish,
                TraitType.King
            };
            Aligments = new List<AlignmentType>
            {
                AlignmentType.Lawful,
                AlignmentType.Evil
            };
            StarWeight = 99;
            StarRate = 9.9f;
            NPGainAtk = 0.86f;
            NPGainDef = 3.0f;
            DeathRate = 19.2f;
            InterludeCount = 2;
            Cards = new List<Card>
            {
                new Card(CardType.Quick, 2),
                new Card(CardType.Arts, 2),
                new Card(CardType.Arts, 2),
                new Card(CardType.Buster, 1),
                new Card(CardType.Buster, 1),
                new Card(CardType.Extra, 3),
            };
            NoblePhantasm = new List<NoblePhantasm>
            {
                new ExcaliburMorganA()
            };
            ActiveSkills = new List<ActiveSkill>
            {
                new ManaBurstA(),
                new IntuitionB(),
                new CharismaE()
            };
            PassiveSkills = new List<PassiveSkill>
            {
                new MagicResistanceB()
            };
            Stats = new List<StatValues>
            {
                new StatValues(1, 1854, 1708),
                new StatValues(40, 6809, 6054),
                new StatValues(50, 8687, 7703),
                new StatValues(60, 10255, 9078),
                new StatValues(70, 11277, 9974),
                new StatValues(80, 11589, 10248),
                new StatValues(90, 12815, 11324),
                new StatValues(100, 14051, 12408)
            };
        }
    }
}
