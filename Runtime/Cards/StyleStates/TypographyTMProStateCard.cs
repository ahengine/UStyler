using UnityEngine;

namespace UStyler
{
    [CreateAssetMenu(fileName = "Typography TMPro State Card", menuName = "UStyler/State Card/Typography TMPro State Card", order = 0)]
    public class TypographyTMProStateCard : StyleStateCard<TypographyTMProState, TypographyTMProCard> { }

    [System.Serializable]
    public class TypographyTMProState : StyleState<TypographyTMProCard> { }
}