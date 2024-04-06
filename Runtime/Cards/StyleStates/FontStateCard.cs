using UnityEngine;

namespace UStyle
{
    [CreateAssetMenu(fileName = "ColorCard", menuName = "UStyler/ColorStateCard", order = 0)]
    public class FontStateCard : StyleStateCard<FontState, FontCard> { }

    [System.Serializable]
    public class FontState : StyleState<FontCard> { }
}