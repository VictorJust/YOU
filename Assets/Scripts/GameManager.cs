using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject spawnManager;
    [SerializeField] private Text endingText;
    [SerializeField] private List<GameObject> planets;

    private GameObject planet;
    
    public bool isGameActive;
    private bool isSoundActive;
    private bool isPlanetCreated;

    private void Start()
    {
        isPlanetCreated = false;
        isGameActive = true;
        isSoundActive = true;
        planet = planets[Random.Range(0, planets.Capacity - 1)];
    }

    private void Update()
    {
        if (isGameActive == false && isPlanetCreated == false)
        {
            GameOver();
            endingText.gameObject.SetActive(true);
            isPlanetCreated = true;
        }
    }

    private void GameOver()
    {
        spawnManager.SetActive(false);
        Instantiate(planet, new Vector3(8, 0, 0), Quaternion.identity);
    }

    public void SoundSwitch()
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

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
}
