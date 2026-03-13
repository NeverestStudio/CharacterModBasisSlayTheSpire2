using HarmonyLib;
using MegaCrit.Sts2.Core.Modding;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Models.Characters;
using MegaCrit.Sts2.Core.Logging;
using MegaCrit.Sts2.Core.Helpers;
using MegaCrit.Sts2.Core.Assets;
using MegaCrit.Sts2.Core.Bindings.MegaSpine;
using System.Collections.Generic;
using System.Linq;
using TomeMod.Characters;

namespace TomeMod;

[ModInitializer("Initialize")]
public class ModEntry
{
    public static void Initialize()
    {

        var harmony = new Harmony("tome.mod");
        harmony.PatchAll();
        var tome = ModelDb.Character<Tome>();
    }
}

