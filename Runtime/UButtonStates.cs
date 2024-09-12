using UnityEngine;

namespace UStyler
{
    [CreateAssetMenu(fileName = "UButtonStates", menuName = "UStyler/Button States Card", order = 0)]
    public class UButtonStates : ScriptableObject
    {
        [field:SerializeField] public StateCard Default {private set; get;}
        [field:SerializeField] public StateCard Hover {private set; get;}
        [field:SerializeField] public StateCard Select {private set; get;}
        [field:SerializeField] public StateCard Disable {private set; get;}
    }
}