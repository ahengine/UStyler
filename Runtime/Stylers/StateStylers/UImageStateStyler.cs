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
            if (!style || !styleComp)
                return;

            base.SetStyle(style);
            styleComp.sprite = style.Sprite;
            styleComp.color = style.Color;
        }
    }
}