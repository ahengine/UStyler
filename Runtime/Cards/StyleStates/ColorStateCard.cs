using UnityEngine;

namespace UStyle
{
    [CreateAssetMenu(fileName = "ColorCard", menuName = "UStyler/ColorStateCard", order = 0)]
    public class ColorStateCard : StyleStateCard<ColorState, ColorCard> { }

    [System.Serializable]
    public class ColorState : StyleState<ColorCard> { }
}