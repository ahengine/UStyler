using UnityEngine;

namespace UStyler
{
    [CreateAssetMenu(fileName = "Color State Card", menuName = "UStyler/State Card/Color State Card", order = 0)]
    public class ColorStateCard : StyleStateCard<ColorState, ColorCard> { }

    [System.Serializable]
    public class ColorState : StyleState<ColorCard> { }
}