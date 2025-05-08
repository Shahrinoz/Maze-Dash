using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompleteUI : MonoBehaviour
{
    public GameObject levelCompletePanel;

    public void ShowLevelComplete()
    {
        levelCompletePanel.SetActive(true);
    }

    public void NextLevel()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextSceneIndex);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0); // Assuming MainMenu is at index 0
    }
}
