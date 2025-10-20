using UnityEngine;

public class ClickSpawner : MonoBehaviour
{
    [SerializeField] private GameObject prefabToSpawn;
    [SerializeField] private float spawnOffset = 0.1f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Vector3 spawnPoint = hit.point + hit.normal * spawnOffset;
                GameObject spanwedObject = Instantiate(prefabToSpawn, spawnPoint, Quaternion.identity);
                Destroy(spanwedObject, 0.3f);
                Debug.Log("Spawned prefab at: " + spawnPoint);
            }
        }
    }
}
