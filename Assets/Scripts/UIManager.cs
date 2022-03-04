
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void ChangeScene(int indx)
    {
        SceneManager.LoadScene(indx);
    }
    public void ExitGame()
    {
        Application.Quit();
    }

}
