using UnityEngine;

namespace UStyler
{
    [CreateAssetMenu(fileName = "Image Card", menuName = "UStyler/Card/Image Card", order = 0)]
    public class ImageCard : StyleCard
    {
        [field: SerializeField] public Sprite Sprite { private set; get; }
        [field: SerializeField] public Color Color { private set; get; } = Color.white;
    }
}