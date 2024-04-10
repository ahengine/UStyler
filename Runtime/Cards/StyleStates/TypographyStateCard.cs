using UnityEngine;

namespace UStyle
{
    [CreateAssetMenu(fileName = "Typography State Card", menuName = "UStyler/TypographyStateCard", order = 0)]
    public class TypographyStateCard : StyleStateCard<TypographyState, TypographyCard> { }

    [System.Serializable]
    public class TypographyState : StyleState<TypographyCard> { }
}