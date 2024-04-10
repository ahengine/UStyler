using UnityEngine;
using UStyle;

public class WidgetSample : MonoBehaviour
{
    private UStylerBase styler;
    [SerializeField] private StateCard state;

    [ContextMenu("Apply Style")]
    public void ApplyStyle() =>
        (styler=GetComponent<UStylerBase>()).SetState(state);
}
