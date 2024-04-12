using UnityEngine;

namespace UStyle
{
    [CreateAssetMenu(fileName = "Typography Card", menuName = "UStyler/Typography Card", order = 0)]
    public class TypographyCard : StyleCard
    {
        [field: SerializeField] public int Size { private set; get; } = 14;
        [field: SerializeField] public Font Asset { private set; get; }
        [field: SerializeField] public FontStyle Style { private set; get; }
        //[field: SerializeField] public ColorCard colorCard { private set; get; }
    }
}