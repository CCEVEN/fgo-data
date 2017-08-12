using FGOData.Models.Serialization;
using System.Collections.Generic;

namespace FGOData.Models.Data
{
    public class Siegfried : Servant
    {
        public Siegfried()
        {
            Id = 6;
            Name_EN = "Siegfried";
            Name_JP = "ジークフリート";
            Class = ClassType.Saber;
            Cost = 12;
            Rarity = 4;
            Gender = GenderType.Male;
            Attribute = AttributeType.Earth;
            Traits = new List<TraitType>
            {
                TraitType.BrynhildrsBeloved,
                TraitType.Dragon,
                TraitType.Humanoid,
                TraitType.Riding,
                TraitType.Servant,
                TraitType.WeakToEnumaElish,
                TraitType.King
            };
            Aligments = new List<AlignmentType>
            {
                AlignmentType.Chaotic,
                AlignmentType.Good
            };
            StarWeight = 97;
            StarRate = 10.0f;
            NPGainAtk = 0.83f;
            NPGainDef = 3.0f;
            DeathRate = 28.0f;
            InterludeCount = 2;
            StrengtheningCount = 1;
            Cards = new List<Card>
            {
                new Card(CardType.Quick, 2),
                new Card(CardType.Arts, 2),
                new Card(CardType.Arts, 2),
                new Card(CardType.Buster, 1),
                new Card(CardType.Buster, 1),
                new Card(CardType.Extra, 3),
            };
            NoblePhantasm = new List<RequirementPair<NoblePhantasm>>
            {
                new RequirementPair<NoblePhantasm>
                {
                    //Value = new Balmung()
                },
                new RequirementPair<NoblePhantasm>
                {
                    //Value = new Balmung2(),
                    Requirements = new List<Requirement>
                    {
                        new Requirement(RequirementType.Strengthening, 2)
                    }
                }
            };
            ActiveSkills = new List<RequirementPair<ActiveSkill>>
            {
                new RequirementPair<ActiveSkill>
                {
                    //Value = new GoldenRuleC()
                },
                new RequirementPair<ActiveSkill>
                {
                    //Value = new DisengageA(),
                    Requirements = new List<Requirement>
                    {
                        new Requirement(RequirementType.Interlude, 2)
                    }
                },
                new RequirementPair<ActiveSkill>
                {
                    //Value = new DragonSlayerA()
                },
                new RequirementPair<ActiveSkill>
                {
                    //Value = new DragonSlaterA2(),
                    Requirements = new List<Requirement>
                    {
                        new Requirement(RequirementType.Strengthening, 1)
                    }
                }
            };
            PassiveSkills = new List<PassiveSkill>
            {
                new RidingB()
            };
            Stats = new List<StatValues>
            {
                new StatValues(1, 1363, 2266),
                new StatValues(2, 1369, 2277),
                new StatValues(3, 1383, 2301),
                new StatValues(4, 1403, 2337),
                new StatValues(5, 1424, 2373),
                new StatValues(6, 1458, 2432),
                new StatValues(7, 1492, 2492),
                new StatValues(8, 1533, 2563),
                new StatValues(9, 1574, 2634),
                new StatValues(10, 1628, 2730),
                new StatValues(11, 1683, 2825),
                new StatValues(12, 1737, 2920),
                new StatValues(13, 1806, 3039),
                new StatValues(14, 1874, 3158),
                new StatValues(15, 1949, 3289),
                new StatValues(16, 2024, 3420),
                new StatValues(17, 2106, 3562),
                new StatValues(18, 2194, 3717),
                new StatValues(19, 2290, 3884),
                new StatValues(20, 2378, 4038),
                new StatValues(21, 2481, 4217),
                new StatValues(22, 2583, 4395),
                new StatValues(23, 2685, 4574),
                new StatValues(24, 2794, 4764),
                new StatValues(25, 2910, 4967),
                new StatValues(26, 3026, 5169),
                new StatValues(27, 3142, 5371),
                new StatValues(28, 3265, 5585),
                new StatValues(29, 3387, 5800),
                new StatValues(30, 3510, 6014),
                new StatValues(31, 3640, 6240),
                new StatValues(32, 3769, 6466),
                new StatValues(33, 3899, 6692),
                new StatValues(34, 4028, 6918),
                new StatValues(35, 4165, 7156),
                new StatValues(36, 4294, 7382),
                new StatValues(37, 4431, 7620),
                new StatValues(38, 4567, 7858),
                new StatValues(39, 4703, 8096),
                new StatValues(40, 4833, 8322),
                new StatValues(41, 4969, 8560),
                new StatValues(42, 5106, 8798),
                new StatValues(43, 5242, 9036),
                new StatValues(44, 5371, 9262),
                new StatValues(45, 5508, 9500),
                new StatValues(46, 5637, 9726),
                new StatValues(47, 5767, 9952),
                new StatValues(48, 5896, 10178),
                new StatValues(49, 6026, 10404),
                new StatValues(50, 6149, 10619),
                new StatValues(51, 6271, 10833),
                new StatValues(52, 6394, 11047),
                new StatValues(53, 6510, 11249),
                new StatValues(54, 6626, 11452),
                new StatValues(55, 6742, 11654),
                new StatValues(56, 6851, 11844),
                new StatValues(57, 6953, 12023),
                new StatValues(58, 7056, 12201),
                new StatValues(59, 7158, 12380),
                new StatValues(60, 7246, 12534),
                new StatValues(61, 7342, 12701),
                new StatValues(62, 7431, 12856),
                new StatValues(63, 7512, 12998),
                new StatValues(64, 7587, 13129),
                new StatValues(65, 7662, 13260),
                new StatValues(66, 7731, 13379),
                new StatValues(67, 7799, 13498),
                new StatValues(68, 7853, 13593),
                new StatValues(69, 7908, 13689),
                new StatValues(70, 7962, 13784),
                new StatValues(71, 8003, 13855),
                new StatValues(72, 8044, 13927),
                new StatValues(73, 8071, 13974),
                new StatValues(74, 8092, 14010),
                new StatValues(75, 8112, 14046),
                new StatValues(76, 8126, 14069),
                new StatValues(77, 8140, 14093),
                new StatValues(78, 8153, 14117),
                new StatValues(79, 8167, 14141),
                new StatValues(80, 8181, 14165),
                new StatValues(81, 8262, 14307),
                new StatValues(82, 8351, 14462),
                new StatValues(83, 8433, 14605),
                new StatValues(84, 8521, 14759),
                new StatValues(85, 8610, 14914),
                new StatValues(86, 8692, 15057),
                new StatValues(87, 8780, 15212),
                new StatValues(88, 8869, 15366),
                new StatValues(89, 8951, 15509),
                new StatValues(90, 9040, 15664),
                new StatValues(91, 9128, 15818),
                new StatValues(92, 9210, 15961),
                new StatValues(93, 9299, 16116),
                new StatValues(94, 9387, 16271),
                new StatValues(95, 9469, 16413),
                new StatValues(96, 9558, 16568),
                new StatValues(97, 9646, 16723),
                new StatValues(98, 9728, 16866),
                new StatValues(99, 9817, 17020),
                new StatValues(100, 9905, 17175)
            };
        }
    }
}
