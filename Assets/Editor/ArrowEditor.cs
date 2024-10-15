using UnityEngine;
using UnityEditor;
using System.Diagnostics;

[CustomEditor(typeof(Arrow))]
public class ArrowEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        Arrow arrow = (Arrow)target;
        if (GUILayout.Button("Save Mesh"))
        {
            SaveMesh(arrow);
        }
    }

    void SaveMesh(Arrow arrow)
    {
        Mesh mesh = arrow.GetMesh();
        if (mesh == null)
        {
            UnityEngine.Debug.LogError("No mesh found to save.");
            return;
        }

        // Pad waar de mesh wordt opgeslagen
        string path = "Assets/SavedMeshes/" + "arrow"+ ".asset";
        string folderPath = "Assets/SavedMeshes";

        // Controleer of de map bestaat, anders maak deze aan
        if (!AssetDatabase.IsValidFolder(folderPath))
        {
            AssetDatabase.CreateFolder("Assets", "SavedMeshes");
        }

        // Sla de mesh op als een asset
        AssetDatabase.CreateAsset(mesh, path);
        AssetDatabase.SaveAssets();
        UnityEngine.Debug.Log("Mesh saved as " + path);
    }
}
