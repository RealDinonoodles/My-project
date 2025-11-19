using Unity.Cinemachine;
using UnityEngine;

public class CinemachineCameraSwitch : MonoBehaviour
{
    public CinemachineCamera playerCamera;
    public CinemachineCamera doorCamera;

    public void OnDoorOpen()
    {
        playerCamera.Priority = 5;
        doorCamera.Priority = 10;
    }

    public void OnDoorClose()
    {
        doorCamera.Priority = 5;
        playerCamera.Priority = 10;
    }
}