using UnityEngine;

namespace UStyle
{
    public class UStylerBase : MonoBehaviour
    {
        [SerializeField] private bool parent;
        private UStylerBase[] childs;

        protected virtual void Awake()
        {
            if (parent)
                childs = GetComponentsInChildren<UStylerBase>();
        }

        public virtual void SetState(StateComp state)
        {
            if (parent)
            {
                for (int i = 0; i < childs.Length; i++)
                    childs[i].ApplyState(state);
            }
            else
                ApplyState(state);
        }

        public virtual void ApplyState(StateComp state)
        {

        }
    }
}