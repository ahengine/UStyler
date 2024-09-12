using UnityEngine.UI;

namespace UStyler
{
    public class UColorStateStyler : UStateStyler<ColorStateCard, ColorState, ColorCard, Graphic>
    {
        public override void ApplyState(StateCard state)
        {
            base.ApplyState(state);
            SetStyle(stateCard.Get(state));
        }

        public override void SetStyle(ColorCard style)
        {   
            base.SetStyle(style);
            
            if (!style || !styleComp)
                return;

            styleComp.color = style.Color;
        }
    }
}