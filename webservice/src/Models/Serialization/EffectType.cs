namespace FGOData.Models.Serialization
{
    public enum EffectType
    {
        // Deal damage, for NPs
        Damage,
        // Heal HP
        Heal,
        // Quick card performance buff
        Quick,
        // Arts card performance buff
        Arts,
        // Buster card performance buff
        Buster,
        // Attack buff
        Attack,
        // Defence buff
        Defence,
        // Power up buff
        PowerUp,
        // Special effective multiplier
        SpecialEffective,
        // Damage dealt buff
        DamageDealt,
        // Damage received buff
        DamageReceived,
        // Healing dealt buff
        HealDealt,
        // Healing received buff
        HealReceived,
        // Fill NP gauge
        NPGauge,
        // NP gain from attack/defence
        NPGain,
        // NP damage buff
        NPDamage,
        // Gain crit stars
        Stars,
        // Star gen rate buff
        StarGen,
        // Crit star weight buff
        StarWeight,
        // Crit damage multiplier
        CritDamage,
        // Insta-kill rate buff
        DeathRate,
        // Debuff resistance multiplier
        DebuffResist,
        // Taunt status effect
        Taunt,
        // Guts status effect
        Guts,
        // Dodge status effect
        Dodge,
        // Invincible status effect
        Invincible,
        // Stun status effect
        Stun,
        // Seal status effect
        Seal,
        // Charm status effect
        Charm,
        // HP regen status effect
        HPRegen,
        // Poison status effect
        Poison,
        // Burn status effect
        Burn,
        // Remove active buffs
        RemoveBuff,
        // Ignore Dodge status effect
        IgnoreDodge,
        // Ignore Invincible status effect
        IgnoreInvincible
    }
}