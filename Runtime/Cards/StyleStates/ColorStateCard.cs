using UnityEngine;

namespace UStyle
{
    [CreateAssetMenu(fileName = "Color State Card", menuName = "UStyler/Color State Card", order = 0)]
    public class ColorStateCard : StyleStateCard<ColorState, ColorCard> { }

    [System.Serializable]
    public class ColorState : StyleState<ColorCard> { }
}