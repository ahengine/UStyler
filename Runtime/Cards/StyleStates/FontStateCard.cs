using UnityEngine;

namespace UStyle
{
    [CreateAssetMenu(fileName = "Font State Card", menuName = "UStyler/FontStateCard", order = 0)]
    public class FontStateCard : StyleStateCard<FontState, FontCard> { }

    [System.Serializable]
    public class FontState : StyleState<FontCard> { }
}