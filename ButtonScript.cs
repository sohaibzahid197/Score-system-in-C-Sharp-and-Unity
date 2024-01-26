using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public void startAgain()
    {
        SceneManager.LoadScene(0);
    }
    public void startGame()
    {
        SceneManager.LoadScene(0);
    }
    public void menu()
    {
        SceneManager.LoadScene(1);
    }
}
