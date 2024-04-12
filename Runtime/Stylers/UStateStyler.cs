using UnityEngine;

namespace UStyle
{
    public class UStateStyler<StateCard, StyleStateT, StyleCardT, StyleComp> : UStylerGeneric<StyleCardT,StyleComp>
    where StateCard  : StyleStateCard<StyleStateT, StyleCardT>
    where StyleStateT : StyleState<StyleCardT>
    where StyleCardT  : StyleCard
    where StyleComp  : Component
    {
        [SerializeField] protected StateCard stateCard;
    }
}