using UnityEngine;

public class OpenBossDoor : MonoBehaviour
{
    public BossDoor Door;

    private void OnTriggerEnter(Collider other)
    {
        Door.Open();
    }
}
