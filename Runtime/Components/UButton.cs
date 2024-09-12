using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UStyler
{
    [RequireComponent(typeof(Button))]
    public class UButton : MonoBehaviour
    {
        private Button button;

        private IStateBase[] staters;
        private UButtonStates states;

        private void Awake()
        {
            button = GetComponent<Button>();
            button.transition = Selectable.Transition.None;
            staters = GetComponentsInChildren<IStateBase>();
            states = Resources.Load<UButtonStates>(typeof(UButtonStates).Name);
        }

        private void Start()
        {
            SetEvents();
            ApplyState(states.Default);
        }

        private void SetEvents()
        {
            EventTrigger trigger = button.gameObject.AddComponent<EventTrigger>();

            EventTrigger.Entry pointerEnter = new EventTrigger.Entry
            {
                eventID = EventTriggerType.PointerEnter
            };
            pointerEnter.callback.AddListener((data) => OnPointerEnter((PointerEventData)data));
            trigger.triggers.Add(pointerEnter);

            EventTrigger.Entry pointerExit = new EventTrigger.Entry
            {
                eventID = EventTriggerType.PointerExit
            };
            pointerExit.callback.AddListener((data) => OnPointerExit((PointerEventData)data));
            trigger.triggers.Add(pointerExit);

            EventTrigger.Entry pointerDown = new EventTrigger.Entry
            {
                eventID = EventTriggerType.PointerDown
            };
            pointerDown.callback.AddListener((data) => OnPointerDown((PointerEventData)data));
            trigger.triggers.Add(pointerDown);

            EventTrigger.Entry pointerUp = new EventTrigger.Entry
            {
                eventID = EventTriggerType.PointerUp
            };
            pointerUp.callback.AddListener((data) => OnPointerUp((PointerEventData)data));
            trigger.triggers.Add(pointerUp);
        }

        public void OnPointerEnter(PointerEventData eventData) =>
            ApplyState(states.Hover); 
        public void OnPointerExit(PointerEventData eventData) =>
            ApplyState(states.Default);
        public void OnPointerDown(PointerEventData eventData) =>
            ApplyState(states.Select);
        public void OnPointerUp(PointerEventData eventData) =>
            ApplyState(states.Default);
        private void ApplyState(StateCard state)
        {
            for (int i = 0; i < staters.Length; i++)
                staters[i].ApplyState(state);
        }
    
        public void SetInteractable(bool state)
        {
             button.interactable = state;

             if(state)
                ApplyState(states.Default);
            else
                ApplyState(states.Disable);
        }

        [ContextMenu("Change Interactable")]
        public void ChangeInteractable()
        {
            states = Resources.Load<UButtonStates>(typeof(UButtonStates).Name);
            SetInteractable(!button.interactable);
        }

        [ContextMenu("Apply Default")]
        public void ApplyDefault() =>
            ApplyState(Resources.Load<UButtonStates>(typeof(UButtonStates).Name).Default);
        
    }
}