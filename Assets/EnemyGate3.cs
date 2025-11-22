using UnityEngine;

public class EnemyGate3 : MonoBehaviour
{
    public EnemyGatedDoor3 door;

    private void OnDestroy()
    {
        door.EnemyDestroid();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}