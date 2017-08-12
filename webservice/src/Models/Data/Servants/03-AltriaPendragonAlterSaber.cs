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
                TraitType.Evil,
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
            NoblePhantasm = new List<RequirementPair<NoblePhantasm>>
            {
                new RequirementPair<NoblePhantasm>
                {
                    Value = new ExcaliburMorganA()
                }
            };
            ActiveSkills = new List<RequirementPair<ActiveSkill>>
            {
                new RequirementPair<ActiveSkill>
                {
                    Value = new ManaBurstA()

                },
                new RequirementPair<ActiveSkill>
                {
                    Value = new IntuitionB(),
                    Requirements = new List<Requirement>
                    {
                        new Requirement(RequirementType.Ascension, 1)
                    }
                },
                new RequirementPair<ActiveSkill>
                {
                    Value = new CharismaE(),
                    Requirements = new List<Requirement>
                    {
                        new Requirement(RequirementType.Ascension, 3)
                    }
                }
            };
            PassiveSkills = new List<PassiveSkill>
            {
                new MagicResistanceB()
            };
            Stats = new List<StatValues>
            {
                new StatValues(1, 1708, 1854),
                new StatValues(2, 1716, 1863),
                new StatValues(3, 1733, 1883),
                new StatValues(4, 1759, 1912),
                new StatValues(5, 1784, 1941),
                new StatValues(6, 1827, 1990),
                new StatValues(7, 1870, 2038),
                new StatValues(8, 1921, 2097),
                new StatValues(9, 1972, 2155),
                new StatValues(10, 2041, 2233),
                new StatValues(11, 2109, 2311),
                new StatValues(12, 2177, 2389),
                new StatValues(13, 2263, 2486),
                new StatValues(14, 2348, 2584),
                new StatValues(15, 2442, 2691),
                new StatValues(16, 2536, 2798),
                new StatValues(17, 2638, 2915),
                new StatValues(18, 2749, 3041),
                new StatValues(19, 2869, 3177),
                new StatValues(20, 2980, 3304),
                new StatValues(21, 3108, 3450),
                new StatValues(22, 3236, 3596),
                new StatValues(23, 3364, 3742),
                new StatValues(24, 3501, 3898),
                new StatValues(25, 3646, 4063),
                new StatValues(26, 3791, 4229),
                new StatValues(27, 3936, 4394),
                new StatValues(28, 4090, 4570),
                new StatValues(29, 4244, 4745),
                new StatValues(30, 4398, 4920),
                new StatValues(31, 4560, 5105),
                new StatValues(32, 4722, 5290),
                new StatValues(33, 4884, 5475),
                new StatValues(34, 5047, 5660),
                new StatValues(35, 5217, 5855),
                new StatValues(36, 5380, 6040),
                new StatValues(37, 5551, 6234),
                new StatValues(38, 5721, 6429),
                new StatValues(39, 5892, 6624),
                new StatValues(40, 6054, 6809),
                new StatValues(41, 6225, 7003),
                new StatValues(42, 6396, 7198),
                new StatValues(43, 6567, 7393),
                new StatValues(44, 6729, 7578),
                new StatValues(45, 6900, 7772),
                new StatValues(46, 7062, 7957),
                new StatValues(47, 7224, 8142),
                new StatValues(48, 7387, 8327),
                new StatValues(49, 7549, 8512),
                new StatValues(50, 7703, 8687),
                new StatValues(51, 7856, 8863),
                new StatValues(52, 8010, 9038),
                new StatValues(53, 8155, 9203),
                new StatValues(54, 8300, 9369),
                new StatValues(55, 8446, 9534),
                new StatValues(56, 8582, 9690),
                new StatValues(57, 8710, 9836),
                new StatValues(58, 8838, 9982),
                new StatValues(59, 8967, 10128),
                new StatValues(60, 9078, 10255),
                new StatValues(61, 9197, 10391),
                new StatValues(62, 9308, 10518),
                new StatValues(63, 9411, 10634),
                new StatValues(64, 9505, 10742),
                new StatValues(65, 9598, 10849),
                new StatValues(66, 9684, 10946),
                new StatValues(67, 9769, 11043),
                new StatValues(68, 9838, 11121),
                new StatValues(69, 9906, 11199),
                new StatValues(70, 9974, 11277),
                new StatValues(71, 10025, 11335),
                new StatValues(72, 10077, 11394),
                new StatValues(73, 10111, 11433),
                new StatValues(74, 10136, 11462),
                new StatValues(75, 10162, 11491),
                new StatValues(76, 10179, 11511),
                new StatValues(77, 10196, 11530),
                new StatValues(78, 10213, 11550),
                new StatValues(79, 10230, 11569),
                new StatValues(80, 10248, 11589),
                new StatValues(81, 10350, 11705),
                new StatValues(82, 10461, 11832),
                new StatValues(83, 10563, 11949),
                new StatValues(84, 10675, 12075),
                new StatValues(85, 10786, 12202),
                new StatValues(86, 10888, 12319),
                new StatValues(87, 10999, 12445),
                new StatValues(88, 11110, 12572),
                new StatValues(89, 11213, 12689),
                new StatValues(90, 11324, 12815),
                new StatValues(91, 11435, 12942),
                new StatValues(92, 11537, 13058),
                new StatValues(93, 11648, 13185),
                new StatValues(94, 11759, 13312),
                new StatValues(95, 11862, 13428),
                new StatValues(96, 11973, 13555),
                new StatValues(97, 12084, 13682),
                new StatValues(98, 12186, 13798),
                new StatValues(99, 12297, 13925),
                new StatValues(100, 12408, 14051)
            };
        }
    }
}
