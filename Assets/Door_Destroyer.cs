using UnityEngine;

public class Door_Destroyer : MonoBehaviour
{
  public GameObject Door;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("hello, World"); 
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(Door);
    }
}
