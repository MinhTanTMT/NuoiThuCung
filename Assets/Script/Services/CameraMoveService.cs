using Assets.Script.Interfaces;
using Assets.Script.Models;
using UnityEngine;

namespace Assets.Script.Services
{
    public class CameraMoveService : ICameraMoveService
    {
        private readonly CameraConfig _config;

        public CameraMoveService(CameraConfig config)
        {
            _config = config;
        }

        public Vector3 CalculateNextPosition(Vector3 currentPosition, Vector3 mousePosition, float screenWidth)
        {
            Vector3 nextPos = currentPosition;

            if (mousePosition.x <= _config.edgeThreshold)
                nextPos.x -= _config.moveSpeed * Time.deltaTime;
            else if (mousePosition.x >= screenWidth - _config.edgeThreshold)
                nextPos.x += _config.moveSpeed * Time.deltaTime;

            nextPos.x = Mathf.Clamp(nextPos.x, _config.minX, _config.maxX);
            return nextPos;
        }
    }
}