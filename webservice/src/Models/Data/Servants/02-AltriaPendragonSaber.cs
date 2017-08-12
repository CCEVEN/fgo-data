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
            NoblePhantasm = new List<RequirementPair<NoblePhantasm>>
            {
                new RequirementPair<NoblePhantasm>
                {
                    Value = new Excalibur()
                },
                new RequirementPair<NoblePhantasm>
                {
                    Value = new Excalibur2(),
                    Requirements = new List<Requirement>
                    {
                        new Requirement(RequirementType.Interlude, 2)
                    }
                }
            };
            ActiveSkills = new List<RequirementPair<ActiveSkill>>
            {
                new RequirementPair<ActiveSkill>
                {
                    Value = new CharismaB()
                },
                new RequirementPair<ActiveSkill>
                {
                    Value = new ManaBurstA(),
                    Requirements = new List<Requirement>
                    {
                        new Requirement(RequirementType.Ascension, 1)
                    }
                },
                new RequirementPair<ActiveSkill>
                {
                    Value = new IntuitionA(),
                    Requirements = new List<Requirement>
                    {
                        new Requirement(RequirementType.Ascension, 3)
                    }
                }
            };
            PassiveSkills = new List<PassiveSkill>
            {
                new MagicResistanceA(),
                new RidingB()
            };
            Stats = new List<StatValues>
            {
                new StatValues(1, 1734, 2222),
                new StatValues(2, 1838, 2364),
                new StatValues(3, 1942, 2506),
                new StatValues(4, 2047, 2648),
                new StatValues(5, 2151, 2790),
                new StatValues(6, 2265, 2945),
                new StatValues(7, 2369, 3088),
                new StatValues(8, 2473, 3230),
                new StatValues(9, 2578, 3372),
                new StatValues(10, 2692, 3527),
                new StatValues(11, 2796, 3669),
                new StatValues(12, 2900, 3812),
                new StatValues(13, 3005, 3954),
                new StatValues(14, 3119, 4109),
                new StatValues(15, 3223, 4251),
                new StatValues(16, 3327, 4393),
                new StatValues(17, 3432, 4536),
                new StatValues(18, 3546, 4691),
                new StatValues(19, 3650, 4833),
                new StatValues(20, 3754, 4975),
                new StatValues(21, 3859, 5117),
                new StatValues(22, 3963, 5260),
                new StatValues(23, 4077, 5415),
                new StatValues(24, 4181, 5557),
                new StatValues(25, 4286, 5699),
                new StatValues(26, 4390, 5841),
                new StatValues(27, 4504, 5996),
                new StatValues(28, 4608, 6139),
                new StatValues(29, 4712, 6281),
                new StatValues(30, 4817, 6423),
                new StatValues(31, 4931, 6578),
                new StatValues(32, 5035, 6720),
                new StatValues(33, 5139, 6863),
                new StatValues(34, 5244, 7005),
                new StatValues(35, 5358, 7160),
                new StatValues(36, 5462, 7302),
                new StatValues(37, 5566, 7444),
                new StatValues(38, 5671, 7587),
                new StatValues(39, 5775, 7729),
                new StatValues(40, 5889, 7884),
                new StatValues(41, 5993, 8026),
                new StatValues(42, 6098, 8168),
                new StatValues(43, 6202, 8311),
                new StatValues(44, 6316, 8466),
                new StatValues(45, 6420, 8608),
                new StatValues(46, 6524, 8750),
                new StatValues(47, 6629, 8892),
                new StatValues(48, 6743, 9047),
                new StatValues(49, 6847, 9190),
                new StatValues(50, 6951, 9332),
                new StatValues(51, 7056, 9474),
                new StatValues(52, 7170, 9629),
                new StatValues(53, 7274, 9771),
                new StatValues(54, 7378, 9914),
                new StatValues(55, 7483, 10056),
                new StatValues(56, 7587, 10198),
                new StatValues(57, 7701, 10353),
                new StatValues(58, 7805, 10495),
                new StatValues(59, 7910, 10638),
                new StatValues(60, 8014, 10780),
                new StatValues(61, 8128, 10935),
                new StatValues(62, 8232, 11077),
                new StatValues(63, 8336, 11219),
                new StatValues(64, 8441, 11362),
                new StatValues(65, 8555, 11517),
                new StatValues(66, 8659, 11659),
                new StatValues(67, 8763, 11801),
                new StatValues(68, 8868, 11943),
                new StatValues(69, 8982, 12098),
                new StatValues(70, 9086, 12241),
                new StatValues(71, 9190, 12383),
                new StatValues(72, 9295, 12525),
                new StatValues(73, 9399, 12667),
                new StatValues(74, 9513, 12822),
                new StatValues(75, 9617, 12965),
                new StatValues(76, 9722, 13107),
                new StatValues(77, 9826, 13249),
                new StatValues(78, 9940, 13404),
                new StatValues(79, 10044, 13546),
                new StatValues(80, 10148, 13689),
                new StatValues(81, 10253, 13831),
                new StatValues(82, 10367, 13986),
                new StatValues(83, 10471, 14128),
                new StatValues(84, 10575, 14270),
                new StatValues(85, 10680, 14413),
                new StatValues(86, 10794, 14568),
                new StatValues(87, 10898, 14710),
                new StatValues(88, 11002, 14852),
                new StatValues(89, 11107, 14994),
                new StatValues(90, 11221, 15150),
                new StatValues(91, 11325, 15292),
                new StatValues(92, 11429, 15434),
                new StatValues(93, 11534, 15576),
                new StatValues(94, 11638, 15718),
                new StatValues(95, 11752, 15873),
                new StatValues(96, 11856, 16016),
                new StatValues(97, 11960, 16158),
                new StatValues(98, 12065, 16300),
                new StatValues(99, 12179, 16455),
                new StatValues(100, 12283, 16597)
            };
        }
    }
}
