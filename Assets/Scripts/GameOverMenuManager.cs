using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenuManager : MonoBehaviour
{
    public string againSceneName = "ClassicGame";
    public string mainMenuSceneName = "MainMenu";

    public void PlayAgain()
    {
        SceneManager.LoadScene(againSceneName);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(mainMenuSceneName);
    }

}
