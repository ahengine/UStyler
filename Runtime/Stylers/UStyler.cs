using UnityEngine;

namespace UStyler
{
    public class UStyler<StyleCardT,StyleComp> : UStylerGeneric<StyleCardT, StyleComp>
    where StyleCardT : StyleCard
    where StyleComp : Component
    {
        [SerializeField] protected StyleCardT card;

        protected virtual void OnEnable() =>
            SetStyle(card);

        #if UNITY_EDITOR
        [ContextMenu("Apply Style")]
        private void OnValidate() {
            styleComp = GetComponent<StyleComp>();
            SetStyle(card);
            Debug.Log(name+ " - Style Updated");
        }
        #endif
    }
}