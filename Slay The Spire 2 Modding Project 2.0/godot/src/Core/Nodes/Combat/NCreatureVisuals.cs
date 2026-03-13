using System.Threading.Tasks;
using Godot;
using MegaCrit.Sts2.Core.Assets;
using MegaCrit.Sts2.Core.Bindings.MegaSpine;
using MegaCrit.Sts2.Core.Helpers;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Nodes.Combat;

public partial class NCreatureVisuals : Node2D
{
    private static readonly StringName _overlayInfluence = new StringName("overlay_influence");

    private static readonly StringName _h = new StringName("h");

    private static readonly StringName _tint = new StringName("tint");

    private const double _baseLiquidOverlayDuration = 1.0;

    private float _hue = 1f;

    private double _liquidOverlayTimer;

    private Material? _savedNormalMaterial;

    private ShaderMaterial? _currentLiquidOverlayMaterial;

    public Node2D Body { get; private set; }

    public Control Bounds { get; private set; }

    public Marker2D IntentPosition { get; private set; }

    public Marker2D OrbPosition { get; private set; }

    public Marker2D? TalkPosition { get; private set; }

    public bool HasSpineAnimation
    {
        return false;
    }

    public MegaSprite? SpineBody { get; private set; }

    public Marker2D VfxSpawnPosition { get; private set; }

    public float DefaultScale { get; set; } = 1f;

    public override void _Ready()
    {

    }

    public void SetUpSkin(MonsterModel model)
    {

    }

    public void SetScaleAndHue(float scale, float hue)
    {

    }

    public bool IsPlayingHurtAnimation()
    {
        return false;
    }

    public void TryApplyLiquidOverlay(Color tint)
    {

    }

    private async Task ApplyLiquidOverlayInternal(Color tint)
    {

    }
}
