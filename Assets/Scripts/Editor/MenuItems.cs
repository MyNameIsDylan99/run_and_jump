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

        [MenuItem("Tools/Level Creator/New Level Settings")]
        private static void NewLevelSettings()
        {
            string path = EditorUtility.SaveFilePanelInProject(
            "New Level Settings",
            "LevelSettings",
            "asset",
            "Define the name for the LevelSettings asset");
            if (path != "")
            {
                EditorUtils.CreateAsset<LevelSettings>(path);
            }
        }

    }
}
