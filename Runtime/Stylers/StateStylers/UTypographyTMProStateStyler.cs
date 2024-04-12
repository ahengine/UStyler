using TMPro;

namespace UStyle
{
    public class UTypographyTMProStateStyler : UStateStyler<TypographyTMProStateCard, TypographyTMProState, TypographyTMProCard,TextMeshProUGUI >
    {
        public override void ApplyState(StateCard state)
        {
            base.ApplyState(state);
            SetStyle(stateCard.Get(state));
        }

        public override void SetStyle(TypographyTMProCard style)
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