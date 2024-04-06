using UnityEngine;
using UStyle;

public class WidgetTest : MonoBehaviour
{
    [SerializeField] private UStylerBase styler;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
            SetState(StateComp.Selected);
    }

    private void SetState(StateComp state) 
    {
        styler?.SetState(state);
    }
}