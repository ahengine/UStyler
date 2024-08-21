using UnityEngine.UI;

namespace UStyler
{
    public class UTypographyStyler : UStyler<TypographyCard, Text>
    {
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