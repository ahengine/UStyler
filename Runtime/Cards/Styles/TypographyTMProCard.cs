using TMPro;
using UnityEngine;

namespace UStyler
{
    [CreateAssetMenu(fileName = "Typography TMPro Card", menuName = "UStyler/Card/Typography TMPro Card", order = 0)]
    public class TypographyTMProCard : StyleCard
    {
        [field: SerializeField] public int Size { private set; get; } = 14;
        [field: SerializeField] public TMP_FontAsset Asset { private set; get; }
        [field: SerializeField] public FontStyles Style { private set; get; }
        //[field: SerializeField] public ColorCard colorCard { private set; get; }
    }
}