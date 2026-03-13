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

namespace TomeMod.Patches
{
[HarmonyPatch(typeof(ModelDb), "AllCharacters", MethodType.Getter)]
public static class CharacterPoolPatch
{
    static void Postfix(ref IEnumerable<CharacterModel> __result)
    {
        if (__result == null)
        {
            return;
        }

        var list = __result.ToList();

        CharacterModel tome;

        try
        {
            tome = ModelDb.Character<Tome>();
        }
        catch
        {
            return;
        }

        if (!list.Contains(tome))
        {
            list.Add(tome);
        }
        else
        {
            return;
        }

        __result = list;
    }
}


// [HarmonyPatch(typeof(SceneHelper), nameof(SceneHelper.GetScenePath))]
// public static class ScenePathRedirectPatch
// {
//     static void Prefix(ref string innerPath)
//     {
//         if (innerPath != null && innerPath.Contains("tome"))
//         {
//             innerPath = innerPath.Replace("tome", "ironclad");
//         }
//     }
// }


[HarmonyPatch(typeof(ImageHelper), nameof(ImageHelper.GetImagePath))]
public static class ImagePathRedirectPatch
{
    static void Prefix(ref string innerPath)
    {
        if (innerPath != null && innerPath.Contains("tome"))
        {
            innerPath = innerPath.Replace("tome", "ironclad");
        }
    }
}

[HarmonyPatch(typeof(AssetCache), "LoadAsset")]
class AssetRedirectPatch
{
    static void Prefix(ref string path)
    {
        if (path != null && path.Contains("tome"))
        {
            path = path.Replace("tome", "ironclad");
        }
    }
}
}