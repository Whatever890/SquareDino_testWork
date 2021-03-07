using UnityEngine;
using Cinemachine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera menuCamera = null;
    [SerializeField] private CinemachineVirtualCamera combatCamera = null;

    public void SwitchCamera(bool toCombat)
    {
        if (toCombat)
        {
            menuCamera.Priority = 0;
            combatCamera.Priority = 1;
        }
        else
        {
            menuCamera.Priority = 1;
            combatCamera.Priority = 0;
        }
    }
}
