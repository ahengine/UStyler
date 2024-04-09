using UnityEngine;

namespace UStyle
{
    public class UStyler<StateCard, StyleStateT, StyleCardT, StyleComp> : UStylerBase
    where StateCard  : StyleStateCard<StyleStateT, StyleCardT>
    where StyleStateT : StyleState<StyleCardT>
    where StyleCardT  : StyleCard
    where StyleComp  : Component
    {

        [SerializeField] protected StateCard stateCard;
        protected StyleComp styleComp;

        protected override void Awake()
        {
            base.Awake();
            styleComp = GetComponent<StyleComp>();
        }
    }
}