using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject spawnManager;

    public bool isGameActive;
    private bool isSoundActive;

    private void Start()
    {
        isGameActive = true;
        isSoundActive = true;
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

    public void soundSwitch()
    {
        if (isSoundActive == true)
        {
            GameObject.FindObjectOfType<AudioSource>().Pause();
            isSoundActive = false;
        }
        else
        {
            GameObject.FindObjectOfType<AudioSource>().Play();
            isSoundActive = true;
        }
    }

    public void ExitToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
