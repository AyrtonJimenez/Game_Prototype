using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public static bool isPaused;

    private bool hasPaused = false;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if(!hasPaused && Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
        else
        {
            //ResumeGame();
        }
    }
    public void PauseGame()
    {
        Instantiate(pauseMenu);
        isPaused = true;
        Debug.Log("Opened Pause Menu");
        Time.timeScale = 0f;
    }
    public void ResumeGame()
    {
        Destroy(pauseMenu);
        isPaused = false;
        Debug.Log("Closed Pause Menu");
        Time.timeScale = 1f;
    }
    /*public void CheckPauseMenu()
    {
        if(isPaused)
        {
            ResumeGame();
        }
        else
        {
            PauseGame();
        }
    }*/
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
