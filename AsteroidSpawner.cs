using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject[] asteroidPrefabs;
    public float secondsBetweenAsteroids = 1.5f;
    public Vector2 forceRange;
    public Camera cam;
    float timer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            spawnAsteroid();
            timer += secondsBetweenAsteroids;
        }
    }

    public void spawnAsteroid()
    {
        int side = Random.Range(0, 4);
        Vector2 spawnPoint = Vector2.zero;
        Vector2 direction = Vector2.zero;
        switch (side)
        {
            case 0:
                // Left
                spawnPoint.x = 0;
                spawnPoint.y = Random.value; // Always Gives Values Between 0 And 1
                direction = new Vector2(1f, Random.Range(-1f, 1f));
                break;
            case 1:
                // Right
                spawnPoint.x = 1;
                spawnPoint.y = Random.value; // Always Gives Values Between 0 And 1
                direction = new Vector2(-1f, Random.Range(-1f, 1f));
                break;
            case 2:
                // Bottom
                spawnPoint.y = 0;
                spawnPoint.x = Random.value; // Always Gives Values Between 0 And 1
                direction = new Vector2(Random.Range(-1f, 1f), 1f);
                break;
            case 3:
                // Top
                spawnPoint.y = 1;
                spawnPoint.x = Random.value; // Always Gives Values Between 0 And 1
                direction = new Vector2(Random.Range(-1f, 1f), -1f);
                break;
        }
                   Vector3 worldSpawnPoint = cam.ViewportToWorldPoint(spawnPoint);
                         worldSpawnPoint.z = 0;
                         GameObject selectedAsteroid =
                          asteroidPrefabs[Random.Range(0, asteroidPrefabs.Length)];
                      GameObject asteroidInstance =  Instantiate(selectedAsteroid,worldSpawnPoint,Quaternion.Euler(0,0,Random.Range(0,360)));
                      Rigidbody rb = asteroidInstance.GetComponent<Rigidbody>();
                      rb.velocity = direction.normalized * Random.Range(forceRange.x,forceRange.y);



    }
}