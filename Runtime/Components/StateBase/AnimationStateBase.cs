using UnityEngine;

namespace UStyler
{
    public class AnimationStateBase : StatePlayerBase<AnimationStateData>
    {
        public override void ApplyState(StateCard state)
        {
            for(int i=0; i<states.Length; i++)
                if(states[i].state == state)
                {
                    var curState = states[i].value;

                    switch(curState.behaviour)
                    {
                        default:
                        case AnimationStateData.Behaviour.Play:
                            curState.animator.Play(curState.value);
                            break;

                        case AnimationStateData.Behaviour.Trigger:
                            curState.animator.SetTrigger(curState.value);
                            break;

                        case AnimationStateData.Behaviour.Bool:
                            curState.animator.SetBool(curState.value, curState.parameter.boolean);
                            break;

                        case AnimationStateData.Behaviour.Int:
                            curState.animator.SetInteger(curState.value, curState.parameter.integer);
                            break;

                        case AnimationStateData.Behaviour.Float:
                            curState.animator.SetFloat(curState.value, curState.parameter._float);
                            break;                   
                    }
                    break;
                }
        }
    }

    [System.Serializable]
    public class AnimationStateData 
    {
        public enum Behaviour {Play, Trigger, Bool, Int, Float}
        public Animator animator;
        public string value;
        public Behaviour behaviour;
        public AnimationStateParameter parameter;
    }

    [System.Serializable]
    public class AnimationStateParameter
    {
        public bool boolean;
        public int integer;
        public float _float;
    }
}