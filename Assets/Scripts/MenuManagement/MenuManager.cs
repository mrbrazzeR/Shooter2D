using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;
    public void GameStart(int SceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneID);
    }
    public void Exit()
    {
        Application.Quit();
    }
    private void Start()
    {
        Screen.SetResolution(720, 1560, FullScreenMode.ExclusiveFullScreen, 60);
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }
}
