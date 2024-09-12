using UnityEngine;

namespace UStyler
{
    public abstract class StatePlayerBase<T> : MonoBehaviour, IStateBase
    {
        [SerializeField] protected ItemState<T>[] states;
        public abstract void ApplyState(StateCard state);
    }
}