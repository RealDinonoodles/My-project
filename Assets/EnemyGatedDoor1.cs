using UnityEngine;

public class EnemyGatedDoor1 : MonoBehaviour
{

    int numEnemyRemain = 5;

    public void EnemyDestroid()
    {
        numEnemyRemain--;
        if (numEnemyRemain <= 0 )
            Destroy(gameObject);
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
