using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public int lives = 10;

   public void loadMazeFun()
    {
        SceneManager.LoadScene("SampleScene");
        PlayerPrefs.SetInt("lives", lives);
    }
    public void QuitGame()
    {
        Application.Quit();
    }


}
