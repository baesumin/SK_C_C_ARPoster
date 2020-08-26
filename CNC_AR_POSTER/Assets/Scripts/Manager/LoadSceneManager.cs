using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadSceneManager : MonoBehaviour
{
    public void OnPoster1Click()
    {
        SceneManager.LoadScene("poster1");
    }
    public void OnPoster2Click()
    {
        SceneManager.LoadScene("poster2");
    }
    public void OnPoster3Click()
    {
        SceneManager.LoadScene("poster3");
    }
    public void OnBackClick()
    {
        SceneManager.LoadScene("main");
    }
}
