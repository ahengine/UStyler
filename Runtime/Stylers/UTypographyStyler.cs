using UnityEngine.UI;

namespace UStyle
{
    public class UTypographyStyler : UStyler<TypographyStateCard, TypographyState, TypographyCard, Text>
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