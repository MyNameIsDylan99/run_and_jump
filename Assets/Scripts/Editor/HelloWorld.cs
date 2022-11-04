using UnityEngine;
using UnityEditor;
public class HelloWorld
{
    [MenuItem("GameObject/Create HelloWorld")]
    private static void CreateHelloWorldGameObject()
    {
        if (EditorUtility.DisplayDialog(
        "Hello World",
        "Do you really want to do this?",
        "Create",
        "Cancel"))
        {
            new GameObject("HelloWorld");
        }
    }
}