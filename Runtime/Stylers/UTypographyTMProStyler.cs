using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace UStyle
{
    public class UTypographyTMProStyler : UStyler<TypographyTMProStateCard, TypographyTMProState, TypographyTMProCard,TextMeshProUGUI >
    {
        public override void ApplyState(StateComp state)
        {
            base.ApplyState(state);
            
            var fontData = stateCard.Get(state);

            styleComp.font = fontData.Asset;
            styleComp.fontStyle = fontData.Style;
            styleComp.fontSize = fontData.Size;
            styleComp.color = fontData.colorCard.Color;
        }
    }
}