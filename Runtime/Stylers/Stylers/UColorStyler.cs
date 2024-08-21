using UnityEngine.UI;

namespace UStyler
{
    public class UColorStyler : UStyler<ColorCard, Graphic>
    {
        public override void SetStyle(ColorCard style)
        {        
            if (!style || !styleComp)
                return;

            base.SetStyle(style);
            styleComp.color = style.Color;
        }
    }
}