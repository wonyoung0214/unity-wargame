using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void Quitgame()
    {
        Application.Quit();
    }

    public void ChangeScene(string name)
    {
        SceneManager.LoadScene(name);
    }

 }
