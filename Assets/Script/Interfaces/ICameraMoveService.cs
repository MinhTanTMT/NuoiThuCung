using UnityEngine;

namespace Assets.Script.Interfaces
{
    public interface ICameraMoveService
    {
        /// <summary>
        /// Calculate Next Position.
        /// </summary>
        /// <param name="currentPosition">CurrentPosition.</param>
        /// <param name="mousePosition">Mouse Position.</param>
        /// <param name="screenWidth">Screen Width.</param>
        /// <returns> Type data Vector3 </returns>
        Vector3 CalculateNextPosition(Vector3 currentPosition, Vector3 mousePosition, float screenWidth);
    }
}
