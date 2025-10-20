using UnityEngine;
public class TriggerExample : MonoBehaviour

{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Entered a new area!");
        }
    }
}