using UnityEngine;

namespace UStyler
{
    [CreateAssetMenu(fileName = "Color Card", menuName = "UStyler/Color Card", order = 0)]
    public class ColorCard : StyleCard
    {
        [field: SerializeField] public Color Color { private set; get; }
    }
}