using System;
using System.Collections.Generic;

namespace FGOData.Models.Serialization
{
    public class Servant
    {
        public int Id { get; set; }
        public string Name_EN { get; set; }
        public string Name_JP { get; set; }
        public ClassType Class { get; set; }
        public int Cost { get; set; }
        public int Rarity { get; set; }
        public GenderType Gender { get; set; }
        public AttributeType Attribute { get; set; }
        public List<TraitType> Traits { get; set; }
        public List<AlignmentType> Aligments { get; set; }
        public int StarWeight { get; set; }
        public float StarRate { get; set; }
        public float NPGainAtk { get; set; }
        public float NPGainDef { get; set; }
        public float DeathRate { get; set; }
        public int InterludeCount { get; set; }
        public int StrengtheningCount { get; set; }
        public List<Card> Cards { get; set; }
        public List<RequirementPair<NoblePhantasm>> NoblePhantasm { get; set; }
        public List<RequirementPair<ActiveSkill>> ActiveSkills { get; set; }
        public List<PassiveSkill> PassiveSkills { get; set; }
        public List<StatValues> Stats { get; set; }
    }
}