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
                new StatValues(1, 1497, 1843),
                new StatValues(2, 1586, 1959),
                new StatValues(3, 1684, 2084),
                new StatValues(4, 1774, 2200),
                new StatValues(5, 1871, 2326),
                new StatValues(6, 1968, 2452),
                new StatValues(7, 2058, 2568),
                new StatValues(8, 2155, 2694),
                new StatValues(9, 2253, 2820),
                new StatValues(10, 2343, 2936),
                new StatValues(11, 2440, 3062),
                new StatValues(12, 2537, 3187),
                new StatValues(13, 2627, 3303),
                new StatValues(14, 2725, 3429),
                new StatValues(15, 2822, 3555),
                new StatValues(16, 2912, 3671),
                new StatValues(17, 3009, 3797),
                new StatValues(18, 3106, 3923),
                new StatValues(19, 3196, 4039),
                new StatValues(20, 3294, 4165),
                new StatValues(21, 3391, 4290),
                new StatValues(22, 3481, 4406),
                new StatValues(23, 3578, 4532),
                new StatValues(24, 3676, 4658),
                new StatValues(25, 3765, 4774),
                new StatValues(26, 3863, 4900),
                new StatValues(27, 3960, 5026),
                new StatValues(28, 4050, 5142),
                new StatValues(29, 4147, 5267),
                new StatValues(30, 4245, 5393),
                new StatValues(31, 4334, 5509),
                new StatValues(32, 4432, 5635),
                new StatValues(33, 4529, 5761),
                new StatValues(34, 4619, 5877),
                new StatValues(35, 4716, 6003),
                new StatValues(36, 4814, 6129),
                new StatValues(37, 4904, 6245),
                new StatValues(38, 5001, 6370),
                new StatValues(39, 5098, 6496),
                new StatValues(40, 5188, 6612),
                new StatValues(41, 5285, 6738),
                new StatValues(42, 5375, 6854),
                new StatValues(43, 5473, 6980),
                new StatValues(44, 5570, 7106),
                new StatValues(45, 5660, 7222),
                new StatValues(46, 5757, 7348),
                new StatValues(47, 5855, 7473),
                new StatValues(48, 5944, 7589),
                new StatValues(49, 6042, 7715),
                new StatValues(50, 6139, 7841),
                new StatValues(51, 6229, 7957),
                new StatValues(52, 6326, 8083),
                new StatValues(53, 6424, 8209),
                new StatValues(54, 6513, 8325),
                new StatValues(55, 6611, 8451),
                new StatValues(56, 6708, 8576),
                new StatValues(57, 6798, 8692),
                new StatValues(58, 6895, 8818),
                new StatValues(59, 6993, 8944),
                new StatValues(60, 7083, 9060),
                new StatValues(61, 7180, 9186),
                new StatValues(62, 7277, 9312),
                new StatValues(63, 7367, 9428),
                new StatValues(64, 7464, 9553),
                new StatValues(65, 7562, 9679),
                new StatValues(66, 7652, 9795),
                new StatValues(67, 7749, 9921),
                new StatValues(68, 7846, 10047),
                new StatValues(69, 7936, 10163),
                new StatValues(70, 8034, 10289),
                new StatValues(71, 8131, 10415),
                new StatValues(72, 8221, 10531),
                new StatValues(73, 8318, 10656),
                new StatValues(74, 8415, 10782),
                new StatValues(75, 8505, 10898),
                new StatValues(76, 8603, 11024),
                new StatValues(77, 8700, 11150),
                new StatValues(78, 8790, 11266),
                new StatValues(79, 8887, 11392),
                new StatValues(80, 8985, 11518),
                new StatValues(81, 9074, 11634),
                new StatValues(82, 9172, 11759),
                new StatValues(83, 9262, 11875),
                new StatValues(84, 9359, 12001),
                new StatValues(85, 9456, 12127),
                new StatValues(86, 9546, 12243),
                new StatValues(87, 9643, 12369),
                new StatValues(88, 9741, 12495),
                new StatValues(89, 9831, 12611),
                new StatValues(90, 9928, 12737),
                new StatValues(91, 10025, 12862),
                new StatValues(92, 10115, 12978),
                new StatValues(93, 10213, 13104),
                new StatValues(94, 10310, 13230),
                new StatValues(95, 10400, 13346),
                new StatValues(96, 10497, 13472),
                new StatValues(97, 10594, 13598),
                new StatValues(98, 10684, 13714),
                new StatValues(99, 10782, 13840),
                new StatValues(100, 10879, 13965)
            };
        }
    }
}
