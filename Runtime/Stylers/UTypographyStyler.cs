using UnityEngine.UI;

namespace UStyle
{
    public class UTypographyStyler : UStyler<TypographyStateCard, TypographyState, TypographyCard, Text>
    {
        public override void ApplyState(StateCard state)
        {
            base.ApplyState(state);

            var fontData = stateCard.Get(state);

            if (!fontData || !styleComp)
                return;

            styleComp.font = fontData.Asset;
            styleComp.fontStyle = fontData.Style;
            styleComp.fontSize = fontData.Size;
            styleComp.color = fontData.colorCard.Color;
        }
    }
}