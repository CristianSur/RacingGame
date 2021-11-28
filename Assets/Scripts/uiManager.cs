using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiManager : MonoBehaviour
{
    public Text scoreText;
    bool gameOver;
    public int score;
    public Button[] buttons;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        score = 0;
        InvokeRepeating("scoreUpdate", 1f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
    }

    void scoreUpdate()
    {
        if (!gameOver)
        {
            score += 1;
        }
    }

    public void gameOverActivate()
    {
        gameOver = true;
        foreach (Button button in buttons)
        {
            button.gameObject.SetActive(true);
        }
    }

    public void Play()
    {
        Application.LoadLevel("SampleScene");
    }
    public void Pause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            foreach (Button button in buttons)
            {
                button.gameObject.SetActive(true);
            }
        }

        else if (Time.timeScale == 0)
        {
            foreach (Button button in buttons)
            {
                button.gameObject.SetActive(false);
            }
            Time.timeScale = 1;
        }

    }

    public void replay()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    public void menu()
    {
        Application.LoadLevel("MainMenu");
    }

    public void exit()
    {
        Application.Quit();
    }
}
