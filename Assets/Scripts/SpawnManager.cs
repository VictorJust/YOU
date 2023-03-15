using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> obstacles;
    [SerializeField] private int spawnDelay = 2;
    private float xPosition;
    private float yPosition;
    private float yRange = 5;
    private int numberOfObstacles;
    private int obstacleIndex;
    private Vector3 spawnPosition;

    private void Start()
    {
        StartCoroutine(SpawnPrefabs());
    }

    IEnumerator SpawnPrefabs()
    {
        while (true)
        {
            numberOfObstacles = Random.Range(3, 5);

            for (int i = 0; i <= numberOfObstacles; i++)
            {
                xPosition = 12;
                yPosition = Random.Range(-yRange, yRange);
                obstacleIndex = Random.Range(0, obstacles.Count);
                spawnPosition = new Vector3(xPosition, yPosition, 0);

                Instantiate(obstacles[obstacleIndex], spawnPosition, Quaternion.identity);
            }
            
            yield return new WaitForSeconds(spawnDelay);
        }
    }
}
