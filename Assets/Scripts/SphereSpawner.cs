using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereSpawner : MonoBehaviour
{
    public GameObject spherePrefab;
    public int sphereCount = 100;
    public float spawnDelay = 1f;
    public float xMin = 0f;
    public float xMax = 20f;
    public float yMin = 0f;
    public float yMax = 500f;

    void Start()
    {
        SpawnSphere();
    }

    void SpawnSphere()
    {
        for (int i = 0; i < sphereCount; i++)
        {
            float xPos = Random.Range(xMin, xMax);
            float yPos = Random.Range(yMin, yMax);
            Vector3 spawnPos = new Vector3(xPos, yPos, 0f);
            GameObject sphere = Instantiate(spherePrefab, spawnPos, Quaternion.identity);
            sphere.GetComponent<Rigidbody>().drag = Random.Range(0f, 0.5f);

        }
    }
}
