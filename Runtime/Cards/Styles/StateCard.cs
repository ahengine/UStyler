using UnityEngine;

namespace UStyle
{
    [CreateAssetMenu(fileName = "StateCard", menuName = "UStyler/StateCard", order = 0)]
    public class StateCard : StyleCard
    {
        [field: SerializeField] public string State { private set; get; }
    }
}