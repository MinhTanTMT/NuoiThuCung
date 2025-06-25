
using System;

namespace Assets.Script.Models
{
    [System.Serializable]
    public class CameraConfig
    {
        public float moveSpeed = 10f;
        public float edgeThreshold = 50f;
        [NonSerialized] public float minX = -10f;
        [NonSerialized] public float maxX = 1f;
    }
}
