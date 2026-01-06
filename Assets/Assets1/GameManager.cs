using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static bool isGameOver;

    public GameObject gameoverScreen;
    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
        gameoverScreen.SetActive(false);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            gameoverScreen.SetActive(true);
        }
    }

    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}