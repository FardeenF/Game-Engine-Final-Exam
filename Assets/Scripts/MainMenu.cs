using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void playClicked()
    {
        SceneManager.LoadScene("Game");
    }

    public void exitClicked()
    {
        Application.Quit();
    }
}
