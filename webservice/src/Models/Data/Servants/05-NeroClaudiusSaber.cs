using FGOData.Models.Serialization;
using System.Collections.Generic;

namespace FGOData.Models.Data
{
    public class NeroClaudiusSaber : Servant
    {
        public NeroClaudiusSaber()
        {
            Id = 5;
            Name_EN = "Nero Claudius";
            Name_JP = "ネロ・クラウディウス";
            Class = ClassType.Saber;
            Cost = 12;
            Rarity = 4;
            Gender = GenderType.Female;
            Attribute = AttributeType.Man;
            Traits = new List<TraitType>
            {
                TraitType.Humanoid,
                TraitType.Riding,
                TraitType.Roman,
                TraitType.Saberface,
                TraitType.Servant,
                TraitType.WeakToEnumaElish,
                TraitType.King
            };
            Aligments = new List<AlignmentType>
            {
                AlignmentType.Chaotic,
                AlignmentType.Good
            };
            StarWeight = 102;
            StarRate = 10.1f;
            NPGainAtk = 0.84f;
            NPGainDef = 3.0f;
            DeathRate = 24.5f;
            InterludeCount = 3;
            Cards = new List<Card>
            {
                new Card(CardType.Quick, 2),
                new Card(CardType.Arts, 2),
                new Card(CardType.Arts, 2),
                new Card(CardType.Buster, 1),
                new Card(CardType.Buster, 1),
                new Card(CardType.Extra, 5),
            };
            NoblePhantasm = new List<RequirementPair<NoblePhantasm>>
            {
                new RequirementPair<NoblePhantasm>
                {
                    //Value = new LausSaintClaudius()
                },
                new RequirementPair<NoblePhantasm>
                {
                    //Value = new LausSaintClaudius2(),
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
                    //Value = new MigraineB()
                },
                new RequirementPair<ActiveSkill>
                {
                    //Value = new ImperialPrivilegeEX(),
                    Requirements = new List<Requirement>
                    {
                        new Requirement(RequirementType.Ascension, 1)
                    }
                },
                new RequirementPair<ActiveSkill>
                {
                    //Value = new ThriceSettingSunA(),
                    Requirements = new List<Requirement>
                    {
                        new Requirement(RequirementType.Interlude, 3)
                    }
                }
            };
            PassiveSkills = new List<PassiveSkill>
            {
                //new MagicResistanceC(),
                new RidingB()
            };
            Stats = new List<StatValues>
            {
                new StatValues(1, 1574, 1880),
                new StatValues(2, 1723, 2067),
                new StatValues(3, 1881, 2265),
                new StatValues(4, 2038, 2462),
                new StatValues(5, 2196, 2659),
                new StatValues(6, 2345, 2847),
                new StatValues(7, 2503, 3045),
                new StatValues(8, 2652, 3232),
                new StatValues(9, 2802, 3420),
                new StatValues(10, 2952, 3607),
                new StatValues(11, 3093, 3785),
                new StatValues(12, 3235, 3963),
                new StatValues(13, 3377, 4140),
                new StatValues(14, 3519, 4318),
                new StatValues(15, 3653, 4486),
                new StatValues(16, 3779, 4644),
                new StatValues(17, 3912, 4812),
                new StatValues(18, 4031, 4960),
                new StatValues(19, 4157, 5118),
                new StatValues(20, 4267, 5256),
                new StatValues(21, 4385, 5404),
                new StatValues(22, 4487, 5533),
                new StatValues(23, 4590, 5661),
                new StatValues(24, 4692, 5789),
                new StatValues(25, 4779, 5898),
                new StatValues(26, 4873, 6016),
                new StatValues(27, 4952, 6115),
                new StatValues(28, 5031, 6214),
                new StatValues(29, 5102, 6303),
                new StatValues(30, 5172, 6391),
                new StatValues(31, 5228, 6461),
                new StatValues(32, 5283, 6530),
                new StatValues(33, 5330, 6589),
                new StatValues(34, 5377, 6648),
                new StatValues(35, 5417, 6698),
                new StatValues(36, 5448, 6737),
                new StatValues(37, 5472, 6767),
                new StatValues(38, 5487, 6786),
                new StatValues(39, 5503, 6806),
                new StatValues(40, 5511, 6816),
                new StatValues(41, 5519, 6826),
                new StatValues(42, 5527, 6836),
                new StatValues(43, 5535, 6846),
                new StatValues(44, 5543, 6855),
                new StatValues(45, 5566, 6885),
                new StatValues(46, 5598, 6925),
                new StatValues(47, 5637, 6974),
                new StatValues(48, 5684, 7033),
                new StatValues(49, 5732, 7092),
                new StatValues(50, 5787, 7162),
                new StatValues(51, 5842, 7231),
                new StatValues(52, 5913, 7320),
                new StatValues(53, 5984, 7408),
                new StatValues(54, 6062, 7507),
                new StatValues(55, 6141, 7606),
                new StatValues(56, 6236, 7724),
                new StatValues(57, 6322, 7833),
                new StatValues(58, 6425, 7961),
                new StatValues(59, 6527, 8090),
                new StatValues(60, 6629, 8218),
                new StatValues(61, 6747, 8366),
                new StatValues(62, 6858, 8504),
                new StatValues(63, 6984, 8662),
                new StatValues(64, 7102, 8810),
                new StatValues(65, 7236, 8978),
                new StatValues(66, 7362, 9136),
                new StatValues(67, 7496, 9304),
                new StatValues(68, 7637, 9482),
                new StatValues(69, 7779, 9659),
                new StatValues(70, 7921, 9837),
                new StatValues(71, 8063, 10015),
                new StatValues(72, 8212, 10202),
                new StatValues(73, 8362, 10390),
                new StatValues(74, 8511, 10578),
                new StatValues(75, 8669, 10775),
                new StatValues(76, 8819, 10963),
                new StatValues(77, 8976, 11160),
                new StatValues(78, 9134, 11358),
                new StatValues(79, 9291, 11555),
                new StatValues(80, 9449, 11753),
                new StatValues(81, 9543, 11871),
                new StatValues(82, 9645, 11999),
                new StatValues(83, 9740, 12118),
                new StatValues(84, 9842, 12246),
                new StatValues(85, 9945, 12374),
                new StatValues(86, 10039, 12493),
                new StatValues(87, 10142, 12621),
                new StatValues(88, 10244, 12750),
                new StatValues(89, 10338, 12868),
                new StatValues(90, 10441, 12996),
                new StatValues(91, 10543, 13125),
                new StatValues(92, 10638, 13243),
                new StatValues(93, 10740, 13372),
                new StatValues(94, 10842, 13500),
                new StatValues(95, 10937, 13618),
                new StatValues(96, 11039, 13747),
                new StatValues(97, 11142, 13875),
                new StatValues(98, 11236, 13994),
                new StatValues(99, 11339, 14122),
                new StatValues(100, 11441, 14250)
            };
        }
    }
}
