using UnityEngine;

namespace UStyler
{
    [CreateAssetMenu(fileName = "Image State Card", menuName = "UStyler/State Card/Image State Card", order = 0)]
    public class ImageStateCard : StyleStateCard<ImageState, ImageCard> { }

    [System.Serializable]
    public class ImageState : StyleState<ImageCard> { }
}