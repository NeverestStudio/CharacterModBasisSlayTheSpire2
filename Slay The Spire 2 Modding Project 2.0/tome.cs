using System.Collections.Generic;
using Godot;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Models.Cards;
using MegaCrit.Sts2.Core.Entities.Characters;
using MegaCrit.Sts2.Core.Helpers;
using MegaCrit.Sts2.Core.Models.CardPools;
using MegaCrit.Sts2.Core.Models.PotionPools;
using MegaCrit.Sts2.Core.Models.RelicPools;
using MegaCrit.Sts2.Core.Models.Potions;
using MegaCrit.Sts2.Core.Models.Relics;

namespace TomeMod.Characters;

public sealed class Tome : CharacterModel
{
    public override CharacterGender Gender => CharacterGender.Neutral;
    protected override CharacterModel? UnlocksAfterRunAs => null;
    public override Color NameColor => StsColors.red;
    public override int StartingHp => 70;
    public override int StartingGold => 99;
    public override CardPoolModel CardPool => ModelDb.CardPool<IroncladCardPool>();
    public override PotionPoolModel PotionPool => ModelDb.PotionPool<IroncladPotionPool>();
    public override RelicPoolModel RelicPool => ModelDb.RelicPool<IroncladRelicPool>();

    public override IEnumerable<CardModel> StartingDeck => new List<CardModel>
    {
        ModelDb.Card<StrikeIronclad>(),
        ModelDb.Card<StrikeIronclad>(),
        ModelDb.Card<StrikeIronclad>(),
        ModelDb.Card<StrikeIronclad>(),
        ModelDb.Card<StrikeIronclad>(),
        ModelDb.Card<DefendIronclad>(),
        ModelDb.Card<DefendIronclad>(),
        ModelDb.Card<DefendIronclad>(),
        ModelDb.Card<DefendIronclad>(),
        ModelDb.Card<Bash>(),
    };

    public override IReadOnlyList<RelicModel> StartingRelics => new List<RelicModel>
    {
        ModelDb.Relic<BurningBlood>()
    };

    public override float AttackAnimDelay => 0.15f;
    public override float CastAnimDelay => 0.25f;
    public override Color EnergyLabelOutlineColor => new Color("004488FF");
    public override Color DialogueColor => new Color("004488");
    public override Color MapDrawingColor => new Color("115599");
    public override Color RemoteTargetingLineColor => new Color("4488BBFF");
    public override Color RemoteTargetingLineOutline => new Color("5599CCFF");
    protected override string CharacterSelectIconPath =>
        ImageHelper.GetImagePath("packed/character_select/char_select_ironclad.png");

    protected override string CharacterSelectLockedIconPath =>
        ImageHelper.GetImagePath("packed/character_select/char_select_ironclad_locked.png");
    public override List<string> GetArchitectAttackVfx()
    {
        return new List<string>
        {
            "vfx/vfx_attack_blunt",
            "vfx/vfx_heavy_blunt",
            "vfx/vfx_attack_slash",
            "vfx/vfx_bloody_impact",
            "vfx/vfx_rock_shatter"
        };
    }
}