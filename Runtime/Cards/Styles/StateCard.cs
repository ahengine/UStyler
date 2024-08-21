using UnityEngine;

namespace UStyler
{
    [CreateAssetMenu(fileName = "State Card", menuName = "UStyler/State Card", order = 0)]
    public class StateCard : StyleCard
    {
        [field: SerializeField] public string State { private set; get; }
    }
}