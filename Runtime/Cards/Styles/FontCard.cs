using UnityEngine;

namespace UStyle
{
    [CreateAssetMenu(fileName = "FontStyleCard", menuName = "FontStyleCard", order = 0)]
    public class FontCard : StyleCard
    {
        [field: SerializeField] public int FontSize { private set; get; }
    }
}