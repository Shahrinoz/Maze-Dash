using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Maze Dash"); 
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
