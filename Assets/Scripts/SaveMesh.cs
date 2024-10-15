using UnityEngine;
using UnityEditor;
using System.IO;

public class SaveMesh : MonoBehaviour
{
    public MeshFilter meshFilter;

    [ContextMenu("Save Mesh")]
    public void SaveMeshAsAsset()
    {
        if (meshFilter == null)
        {
            Debug.LogError("MeshFilter is not assigned!");
            return;
        }

        Mesh mesh = meshFilter.sharedMesh;

        if (mesh == null)
        {
            Debug.LogError("Mesh is not found!");
            return;
        }

        // Maak een unieke naam aan voor de mesh
        string path = "Assets/SavedMeshes/" + mesh.name + ".asset";
        string folderPath = "Assets/SavedMeshes";

        // Controleer of de folder bestaat, zo niet, maak deze aan
        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
        }

        AssetDatabase.CreateAsset(mesh, path);
        AssetDatabase.SaveAssets();
        Debug.Log("Mesh saved as " + path);
    }
}
