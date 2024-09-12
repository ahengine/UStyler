using UnityEngine;

namespace UStyler
{
    public class GameObjectStateBase : StatePlayerBase<GameObject>
    {
        public override void ApplyState(StateCard state)
        {
            for(int i=0; i<states.Length; i++)
                states[i].value.SetActive(states[i].state == state);
        }
    }
}