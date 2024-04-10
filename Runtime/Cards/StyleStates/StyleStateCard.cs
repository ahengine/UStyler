using UnityEngine;

namespace UStyle
{
    public abstract class StyleStateCard<StyleStateType, StyleCardType> : ScriptableObject where StyleStateType : StyleState<StyleCardType> where StyleCardType : StyleCard
    {
        [SerializeField] private StyleStateType[] states;

        public virtual StyleCardType Get(StateCard state)
        {
            for (int i = 0; i < states.Length; i++)
                if (states[i].state == state)
                    return states[i].Card;

            return null;
        }
    }

    [System.Serializable]
    public class StyleState<T> where T : StyleCard
    {
        public StateCard state;
        public T Card;
    }
}