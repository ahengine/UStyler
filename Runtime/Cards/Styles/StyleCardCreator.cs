using UnityEngine;
using UnityEditor;

namespace UStyler
{
    public static class StyleCardCreator
    {
        [MenuItem("Assets/Create/UStyler/Color")]
        public static void CreateColorCard() =>
            CardCreator.CreateAsset<ColorCard>();

        [MenuItem("Assets/Create/UStyler/State")]
        public static void CreateStateCard() =>
            CardCreator.CreateAsset<StateCard>();

        [MenuItem("Assets/Create/UStyler/Typography")]
        public static void CreateTypographyCard() =>
            CardCreator.CreateAsset<TypographyCard>();
     
        [MenuItem("Assets/Create/UStyler/TypographyTMPro")]
        public static void CreateTypographyTMProCard() =>
            CardCreator.CreateAsset<TypographyTMProCard>();
    }
}