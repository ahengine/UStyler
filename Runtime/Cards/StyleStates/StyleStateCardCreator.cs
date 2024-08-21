using UnityEngine;
using UnityEditor;

namespace UStyler
{
    public static class StyleStateCardCreator
    {
        [MenuItem("Assets/Create/UStyler/ColorState")]
        public static void CreateColorStateCard() =>
           CardCreator.CreateAsset<ColorStateCard>();

        [MenuItem("Assets/Create/UStyler/TypographyState")]
        public static void CreateTypographyStateCard() =>
            CardCreator.CreateAsset<TypographyStateCard>();
     
        [MenuItem("Assets/Create/UStyler/TypographyTMProState")]
        public static void CreateTypographyTMProStateCard() =>
           CardCreator.CreateAsset<TypographyTMProStateCard>();
    }
}