using UnityEngine.UI;

namespace UStyler
{
    public class UTypographyStateStyler : UStateStyler<TypographyStateCard, TypographyState, TypographyCard, Text>
    {
        public override void ApplyState(StateCard state)
        {
            base.ApplyState(state);
            SetStyle(stateCard.Get(state));
        }

        public override void SetStyle(TypographyCard style)
        {
            base.SetStyle(style);

            if (!style || !styleComp)
                return;

            styleComp.font = style.Asset;
            styleComp.fontStyle = style.Style;
            styleComp.fontSize = style.Size;
        }
    }
}