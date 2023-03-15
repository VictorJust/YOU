using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject spawnManager;
    
    public bool isGameActive;

    private void Start()
    {
        isGameActive = true;
    }

    private void Update()
    {
        if (isGameActive == false)
        {
            GameOver();
        }
    }

    private void GameOver()
    {
        spawnManager.SetActive(false);
    }
}
