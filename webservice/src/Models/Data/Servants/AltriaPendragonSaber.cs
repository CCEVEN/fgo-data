using FGOData.Models.Serialization;
using System.Collections.Generic;

namespace FGOData.Models.Data
{
    public class AltriaPendragonSaber : Servant
    {
        public AltriaPendragonSaber()
        {
            Id = 2;
            Name_EN = "Altria Pendragon";
            Name_JP = "アルトリア・ペンドラゴン";
            Class = ClassType.Saber;
            Cost = 16;
            Rarity = 5;
            Gender = GenderType.Female;
            Attribute = AttributeType.Earth;
            Traits = new List<TraitType>
            {
                TraitType.Arthur,
                TraitType.Dragon,
                TraitType.Humanoid,
                TraitType.Riding,
                TraitType.Saberface,
                TraitType.Servant,
                TraitType.WeakToEnumaElish,
                TraitType.King
            };
            Aligments = new List<AlignmentType>
            {
                AlignmentType.Lawful,
                AlignmentType.Good
            };
            StarWeight = 102;
            StarRate = 10.0f;
            NPGainAtk = 0.86f;
            NPGainDef = 3.0f;
            DeathRate = 21.0f;
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
                new ExcaliburA(),
                new ExcaliburA2()
            };
            ActiveSkills = new List<ActiveSkill>
            {
                new CharismaB(),
                new ManaBurstA(),
                new IntuitionA()
            };
            PassiveSkills = new List<PassiveSkill>
            {
                new MagicResistanceA(),
                new RidingB()
            };
            Stats = new List<StatValues>
            {
                new StatValues(1, 2222, 1734),
                new StatValues(50, 9332, 6951),
                new StatValues(60, 10780, 8014),
                new StatValues(70, 12241, 9086),
                new StatValues(80, 13689, 10148),
                new StatValues(90, 15150, 11221),
                new StatValues(100, 16597, 12283)
            };
        }
    }
}
