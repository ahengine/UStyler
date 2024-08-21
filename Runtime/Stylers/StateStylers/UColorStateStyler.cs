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
            if (!style || !styleComp)
                return;

            base.SetStyle(style);
            styleComp.color = style.Color;
        }
    }
}