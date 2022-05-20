using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public GameObject endMenu;

    public void backHome(int SceneID)
    {
        SceneManager.LoadScene(SceneID);
        Time.timeScale = 1;
    }
    public void ReStart(int SceneID)
    {
        SceneManager.LoadScene(SceneID);
        Time.timeScale = 1;
    }
}
