using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public bool paused;

    public GameObject pauseMenu;

    public PlayerController player;

    // Start is called before the first frame update
    void Start()
    {
        paused = false;
    }

    // Update is called once per frame
    void Update()
    {
        PauseHandler();
    }

    void PauseHandler()
    {
        if (Input.GetKeyDown("p"))
        {
            if (!paused)
            {
                PauseGame();
            } else if (paused)
            {
                ResumeGame();
            }
        }
    }

    public void HomeScreen()
    {
        SceneManager.LoadScene(0);
        ResumeGame();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        ResumeGame();
    }

    public void QuitGame()
    {
        Debug.Log("Quit game!");
        Application.Quit();
    }

    void PauseGame()
    {
        paused = !paused;
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
        player.canMove = false;
    }

    void ResumeGame()
    {
        paused = !paused;
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
        player.canMove = true;
    }
}
