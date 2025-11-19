using UnityEngine;

public class HiddenDoor : MonoBehaviour
{
    public enum DoorState
    {
        Closed,
        Closing,
        Open,
        Opening
    }
    DoorState State;
    float Timeline = 0.0f;
    public float Duration = 1.0f;
    public GameObject Hinge;


    // Update is called once per frame
    void Update()
    {
        switch (State)
        
        {
            case DoorState.Opening:
                Hinge.transform.Rotate(0.0f, (90.0f / Duration) * Time.deltaTime, 0.0f);
                Timeline -= Time.deltaTime;
                if (Timeline <= 0.0f)
                {
                    State = DoorState.Open;
                }
                break;
            case DoorState.Closing:
                Hinge.transform.Rotate(0.0f, (-90.0f / Duration) * Time.deltaTime, 0.0f);
                Timeline -= Time.deltaTime;
                if (Timeline <= 0.0f)
                {
                    State = DoorState.Closed;
                }
                break;
            default:
                break;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        switch (State)
        {
            case DoorState.Closed:
                Debug.Log("Opening!");
                Timeline = Duration;
                State = DoorState.Opening;
                break;
            default:
                break;
        
        }
    }

    private void OnTriggerExit(Collider other)
    {
        switch (State)
        {
            case DoorState.Open:
                Debug.Log("Closing!");
                Timeline = Duration;
                State = DoorState.Closing;
                break;
            default:
                break;

        }
    }
}
