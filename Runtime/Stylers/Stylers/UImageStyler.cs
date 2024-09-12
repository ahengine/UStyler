using UnityEngine.UI;

namespace UStyler
{
    public class UImageStyler : UStyler<ImageCard, Image>
    {
        public override void SetStyle(ImageCard style)
        {        
            if (!style || !styleComp)
                return;

            base.SetStyle(style);
            styleComp.sprite = style.Sprite;
            styleComp.color = style.Color;
        }
    }
}