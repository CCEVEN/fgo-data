using FGOData.Models.Serialization;
using System.Collections.Generic;

namespace FGOData.Models.Data
{
    public class SthenoAssassin : Servant
    {
        public SthenoAssassin()
        {
            Id = 41;
            Name_EN = "Stheno";
            Name_JP = "ステンノ ";
            Class = ClassType.Assassin;
            Cost = 12;
            Rarity = 4;
            Gender = GenderType.Female;
            Attribute = AttributeType.Sky;
            Traits = new List<TraitType>
            {
                TraitType.Humanoid,
                TraitType.Divine,
                TraitType.Servant,
                TraitType.WeakToEnumaElish
            };
            Aligments = new List<AlignmentType>
            {
                AlignmentType.Chaotic,
                AlignmentType.Good
            };
            StarWeight = 104;
            StarRate = 25.0f;
            NPGainAtk = 2.26f;
            NPGainDef = 4.0f;
            DeathRate = 27.5f;
            InterludeCount = 2;
            StrengtheningCount = 1;
            Cards = new List<Card>
            {
                new Card(CardType.Quick, 2),
                new Card(CardType.Quick, 2),
                new Card(CardType.Quick, 2),
                new Card(CardType.Arts, 1),
                new Card(CardType.Buster, 1),
                new Card(CardType.Extra, 3),
            };
            NoblePhantasm = new List<RequirementPair<NoblePhantasm>>
            {
                new RequirementPair<NoblePhantasm>
                {
                    Value = new SmileOfTheStheno()
                }
            };
            ActiveSkills = new List<RequirementPair<ActiveSkill>>
            {
                new RequirementPair<ActiveSkill>
                {
                    Value = new VampirismC()
                },
                new RequirementPair<ActiveSkill>
                {
                    Value = new SirenSongA(),
                    Requirements = new List<Requirement>
                    {
                        new Requirement(RequirementType.Ascension, 1)
                    }
                },
                new RequirementPair<ActiveSkill>
                {
                    Value = new WhimOfTheGoddessA(),
                    Requirements = new List<Requirement>
                    {
                        new Requirement(RequirementType.Strengthening, 1)
                    }
                }
            };
            PassiveSkills = new List<PassiveSkill>
            {
                new CoreOfTheGoddessEX(),
                new MagicResistanceA(),
                new PresenceConcealmentA2()
            };
            Stats = new List<StatValues>
            {
                new StatValues(1, 1843, 1497),
                new StatValues(10, 2936, 2343),
                new StatValues(20, 4165, 3294),
                new StatValues(30, 5393, 4245),
                new StatValues(40, 6612, 5188),
                new StatValues(50, 7841, 6139),
                new StatValues(60, 9060, 7083),
                new StatValues(70, 10289, 8034),
                new StatValues(80, 11518, 8985),
                new StatValues(90, 12737, 9928),
                new StatValues(100, 13965, 10879)
            };
        }
    }
}
