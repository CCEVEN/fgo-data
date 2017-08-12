using FGOData.Models.Serialization;
using System.Collections.Generic;

namespace FGOData.Models.Data
{
    public class AltriaPendragonLilySaber : Servant
    {
        public AltriaPendragonLilySaber()
        {
            Id = 4;
            Name_EN = "Altria Pendragon (Alter)";
            Name_JP = "アルトリア・ペンドラゴン［リリィ］";
            Class = ClassType.Saber;
            Cost = 12;
            Rarity = 4;
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
            InterludeCount = 1;
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
                    //Value = new Caliburn()
                }
            };
            ActiveSkills = new List<RequirementPair<ActiveSkill>>
            {
                new RequirementPair<ActiveSkill>
                {
                    Value = new IntuitionB()

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
                    //Value = new JourneyOfTheFlowersEX(),
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
                new StatValues(1, 1287, 1699),
                new StatValues(2, 1293, 1707),
                new StatValues(3, 1306, 1725),
                new StatValues(4, 1325, 1752),
                new StatValues(5, 1344, 1779),
                new StatValues(6, 1377, 1823),
                new StatValues(7, 1409, 1868),
                new StatValues(8, 1447, 1922),
                new StatValues(9, 1486, 1975),
                new StatValues(10, 1538, 2047),
                new StatValues(11, 1589, 2118),
                new StatValues(12, 1641, 2189),
                new StatValues(13, 1705, 2279),
                new StatValues(14, 1769, 2368),
                new StatValues(15, 1840, 2466),
                new StatValues(16, 1911, 2564),
                new StatValues(17, 1988, 2671),
                new StatValues(18, 2072, 2787),
                new StatValues(19, 2162, 2912),
                new StatValues(20, 2246, 3028),
                new StatValues(21, 2342, 3162),
                new StatValues(22, 2439, 3296),
                new StatValues(23, 2536, 3430),
                new StatValues(24, 2639, 3573),
                new StatValues(25, 2748, 3724),
                new StatValues(26, 2858, 3876),
                new StatValues(27, 2967, 4028),
                new StatValues(28, 3083, 4188),
                new StatValues(29, 3199, 4349),
                new StatValues(30, 3315, 4510),
                new StatValues(31, 3437, 4679),
                new StatValues(32, 3559, 4849),
                new StatValues(33, 3682, 5018),
                new StatValues(34, 3804, 5188),
                new StatValues(35, 3933, 5366),
                new StatValues(36, 4055, 5536),
                new StatValues(37, 4184, 5714),
                new StatValues(38, 4313, 5893),
                new StatValues(39, 4442, 6071),
                new StatValues(40, 4564, 6241),
                new StatValues(41, 4693, 6419),
                new StatValues(42, 4822, 6598),
                new StatValues(43, 4950, 6776),
                new StatValues(44, 5073, 6946),
                new StatValues(45, 5201, 7124),
                new StatValues(46, 5324, 7294),
                new StatValues(47, 5446, 7463),
                new StatValues(48, 5568, 7633),
                new StatValues(49, 5691, 7803),
                new StatValues(50, 5807, 7963),
                new StatValues(51, 5923, 8124),
                new StatValues(52, 6038, 8284),
                new StatValues(53, 6148, 8436),
                new StatValues(54, 6257, 8588),
                new StatValues(55, 6367, 8740),
                new StatValues(56, 6470, 8882),
                new StatValues(57, 6566, 9016),
                new StatValues(58, 6663, 9150),
                new StatValues(59, 6760, 9284),
                new StatValues(60, 6843, 9400),
                new StatValues(61, 6934, 9525),
                new StatValues(62, 7017, 9641),
                new StatValues(63, 7094, 9748),
                new StatValues(64, 7165, 9846),
                new StatValues(65, 7236, 9944),
                new StatValues(66, 7301, 10034),
                new StatValues(67, 7365, 10123),
                new StatValues(68, 7416, 10194),
                new StatValues(69, 7468, 10266),
                new StatValues(70, 7519, 10337),
                new StatValues(71, 7558, 10390),
                new StatValues(72, 7597, 10444),
                new StatValues(73, 7622, 10480),
                new StatValues(74, 7642, 10506),
                new StatValues(75, 7661, 10533),
                new StatValues(76, 7674, 10551),
                new StatValues(77, 7687, 10569),
                new StatValues(78, 7700, 10587),
                new StatValues(79, 7713, 10605),
                new StatValues(80, 7726, 10623),
                new StatValues(81, 7803, 10730),
                new StatValues(82, 7886, 10846),
                new StatValues(83, 7964, 10953),
                new StatValues(84, 8047, 11069),
                new StatValues(85, 8131, 11185),
                new StatValues(86, 8208, 11292),
                new StatValues(87, 8292, 11408),
                new StatValues(88, 8376, 11524),
                new StatValues(89, 8453, 11631),
                new StatValues(90, 8537, 11747),
                new StatValues(91, 8621, 11863),
                new StatValues(92, 8698, 11970),
                new StatValues(93, 8781, 12086),
                new StatValues(94, 8865, 12202),
                new StatValues(95, 8942, 12309),
                new StatValues(96, 9026, 12425),
                new StatValues(97, 9110, 12541),
                new StatValues(98, 9187, 12648),
                new StatValues(99, 9271, 12764),
                new StatValues(100, 9355, 12880)
            };
        }
    }
}
