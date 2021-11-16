using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : MonoBehaviour
{
    GroundSpawner groundSpawner;
    public GameObject obstaclePrefab;

    private Vector3 scaleChange;


    void Start()
    {
        spawnCow();
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
        SpawnCows();
    }
    void OnTriggerExit(Collider other)
    {
        groundSpawner.SpawnTile();
        Destroy(gameObject, 2);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void spawnCow()
    {
        int cowSpawnIndex = Random.Range(2, 5);
        Transform spawnPoint = transform.GetChild(cowSpawnIndex).transform;

        Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
    }
    public GameObject cowprefab;

    void SpawnCows()
    {
        int cows = 6;
        for (int i = 0; i < cows; i++)
        {
            GameObject temp = Instantiate(cowprefab, transform);
            temp.transform.position = randomSpawnPoint(GetComponent<Collider>());
            temp.transform.Rotate(0, 180, 0, Space.World);
            temp.transform.localScale -= temp.transform.localScale / 2;
        }
    }
    Vector3 randomSpawnPoint (Collider collider)
    {
        Vector3 point = new Vector3(
            Random.Range(collider.bounds.min.x, collider.bounds.max.x),
            Random.Range(collider.bounds.min.y, collider.bounds.max.y),
            Random.Range(collider.bounds.min.z, collider.bounds.max.z)
            );
        if (point != collider.ClosestPoint(point))
        {
            point = randomSpawnPoint(collider);
        }
        point.y = 1;
        return point;
    }
    
}
