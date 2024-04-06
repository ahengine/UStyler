using UnityEngine;

namespace UStyle
{
    [CreateAssetMenu(fileName = "ColorCard", menuName = "UStyler/ColorCard", order = 0)]
    public class ColorCard : StyleCard
    {
        [field: SerializeField] public Color Color { private set; get; }
    }
}