using UnityEngine.UI;

namespace UStyler
{
    public class UImageStateStyler : UStateStyler<ImageStateCard, ImageState, ImageCard, Image>
    {
        public override void ApplyState(StateCard state)
        {
            base.ApplyState(state);
            SetStyle(stateCard.Get(state));
        }

        public override void SetStyle(ImageCard style)
        {         
            base.SetStyle(style);
            
            if (!style || !styleComp)
                return;

            styleComp.sprite = style.Sprite;
            styleComp.color = style.Color;
        }
    }
}