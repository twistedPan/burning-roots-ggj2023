using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] private GameObject menuPanel;

    private void Awake()
    {
        Time.timeScale = 1;
        if (SceneManager.GetActiveScene().name == "_MainGameScene")
        {
            menuPanel.SetActive(false);
        }
    }

    public void OnPlay()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void OnQuit()
    {
        Application.Quit();
    }

    public void OnGameOver()
    {
        menuPanel.SetActive(true);
    }
}
