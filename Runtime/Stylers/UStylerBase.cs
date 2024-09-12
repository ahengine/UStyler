using System.Collections.Generic;
using UnityEngine;

namespace UStyler
{
    public class UStylerBase : MonoBehaviour, IStateBase
    {
        [SerializeField] private bool parent;
        private List<IStateBase> childs = new List<IStateBase>();

        protected virtual void Awake()
        {
            if (!parent)
                return;

            var items = GetComponentsInChildren<IStateBase>();

            for (int i = 0; i < items.Length; i++)
                if(items[i] != (IStateBase)this)
                    childs.Add(items[i]);
        }

        public virtual void SetState(StateCard state)
        {
            ApplyState(state);

            if (parent)
            {
                for (int i = 0; i < childs.Count; i++)
                    childs[i].ApplyState(state);
            }  
        }

        public virtual void ApplyState(StateCard state) {}
    }
}