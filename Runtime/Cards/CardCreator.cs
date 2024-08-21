using UnityEngine;
using UnityEditor;

namespace UStyler
{
    public static class CardCreator
    {
            public static void CreateAsset<T>() where T : ScriptableObject
            {
                T asset = ScriptableObject.CreateInstance<T>();

                string path = AssetDatabase.GetAssetPath(Selection.activeObject);
                if (string.IsNullOrEmpty(path))
                    path = "Assets";
                else if (System.IO.Path.GetExtension(path) != "")
                    path = path.Replace(System.IO.Path.GetFileName(AssetDatabase.GetAssetPath(Selection.activeObject)), "");

                string assetPathAndName = AssetDatabase.GenerateUniqueAssetPath(path + "/New " + typeof(T).ToString() + ".asset");

                AssetDatabase.CreateAsset(asset, assetPathAndName);

                AssetDatabase.SaveAssets();
                AssetDatabase.Refresh();
                EditorUtility.FocusProjectWindow();
                Selection.activeObject = asset;
            }
    }
}