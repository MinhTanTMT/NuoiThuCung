using Assets.Script.Interfaces;
using Assets.Script.Models;
using Assets.Script.Services;
using UnityEngine;

namespace Game.Controllers
{
    public class CameraEdgeController : MonoBehaviour
    {
        [SerializeField] private CameraConfig cameraConfig;

        private ICameraMoveService moveService;

        private void Awake()
        {
            moveService = new CameraMoveService(cameraConfig); // inject service
        }

        private void Update()
        {
            Vector3 currentPosition = transform.position;
            Vector3 mousePosition = Input.mousePosition;

            Vector3 newPosition = moveService.CalculateNextPosition(
                currentPosition,
                mousePosition,
                Screen.width
            );

            transform.position = newPosition;
        }
    }
}
