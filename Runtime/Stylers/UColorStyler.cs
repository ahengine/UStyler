using UnityEngine.UI;

namespace UStyle
{
    public class UColorStyler : UStyler<ColorStateCard, ColorState, ColorCard, Graphic>
    {
        public override void ApplyState(StateCard state)
        {
            base.ApplyState(state);

            var colorState = stateCard.Get(state);

            if (!colorState || !styleComp)
                return;

                styleComp.color = colorState.Color;
        }
    }
}