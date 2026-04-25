using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public GameObject playMenuPanel;
    public string classicSceneName = "ClassicGame";
    public string crowdedSceneName = "CrowdedGame";

    private void Start()
    {
        playMenuPanel.SetActive(false);
    }

    public void OpenPlayMenu()
    {
        playMenuPanel.SetActive(true);
    }

    public void ClosePlayMenu()
    {
        playMenuPanel.SetActive(false);
    }

    public void PlayClassic()
    {
        SceneManager.LoadScene(classicSceneName);
    }

    public void PlayCrowded()
    {
        SceneManager.LoadScene(crowdedSceneName);
    }

    public void ExitGame()
    {
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
