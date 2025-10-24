using UnityEngine;

public class TriggerDetector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "microwave") 
        {
            Debug.Log("Food is in the microwave!");
        }
    }
}

