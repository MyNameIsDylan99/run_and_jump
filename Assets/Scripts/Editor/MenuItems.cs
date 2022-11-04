using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace RunAndJump.LevelCreator
{
    public static class MenuItems
    {

        [MenuItem("Tools/Level Creator/New Level Scene")]
        private static void NewLevel()
        {
            EditorUtils.NewLevel();
        }

        [MenuItem("Tools/Level Creator/Show Palette _p")]
        private static void ShowPalette()
        {
            PaletteWindow.ShowPalette();
        }

    }
}
