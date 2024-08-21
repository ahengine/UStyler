using TMPro;

namespace UStyler
{
    public class UTypographyTMProStyler : UStyler<TypographyTMProCard,TextMeshProUGUI >
    {
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