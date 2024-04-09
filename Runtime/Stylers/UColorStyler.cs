using UnityEngine.UI;

namespace UStyle
{
    public class UColorStyler : UStyler<ColorStateCard, ColorState, ColorCard, Graphic>
    {
        public override void ApplyState(StateComp state)
        {
            base.ApplyState(state);

            styleComp.color = stateCard.Get(state).Color;
        }
    }
}