using UnityEngine;

namespace UStyle
{
    public class UStylerGeneric<StyleCardT, StyleComp> : UStylerBase
    where StyleCardT  : StyleCard
    where StyleComp  : Component
    {
        protected StyleComp styleComp;

        protected override void Awake()
        {
            base.Awake();
            styleComp = GetComponent<StyleComp>();
        }
        
        public virtual void SetStyle(StyleCardT style)
        {

        }
    }
}