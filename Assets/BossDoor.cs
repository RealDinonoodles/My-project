using UnityEngine;

public class BossDoor : MonoBehaviour
{
    public bool IsOpening = false;
    float progress = 0.0f;

    // Update is called once per frame
    void Update()
    {
        if (IsOpening)
        {
            Vector3 position = gameObject.transform.position;
            position.z += 0.02f;
            gameObject.transform.position = position;

            progress += Time.deltaTime;
            if (progress > 2.0f)
            {
                IsOpening = false;
                Debug.Log("Done Opening!");
            }
        }
    }

    public void Open()
    {
        IsOpening = true;
    }
}
