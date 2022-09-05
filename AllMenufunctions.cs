using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AllMenufunctions : MonoBehaviour
{
    public GameObject PauseMenu;

    public void Pausegame()
    {
        Time.timeScale = 0;
        PauseMenu.SetActive(true);
    }
    public void Resumegame()
    {
        Time.timeScale = 1;
        PauseMenu.SetActive(false);
    }
    public void Retry()
    {
        Scene m_Scene = SceneManager.GetActiveScene();
        string currentscenename = m_Scene.name;
        SceneManager.LoadScene(currentscenename);
        Time.timeScale = 1;
    }
}
