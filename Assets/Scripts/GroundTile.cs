using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : MonoBehaviour
{
    GroundSpawner groundSpawner;
    public GameObject obstaclePrefab;


    void Start()
    {
        spawnCow();
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
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

}
