using UnityEngine.SceneManagement;
using UnityEngine;

public class title_screen_controler : MonoBehaviour {
    public void StartGame()
    {
        SceneManager.LoadScene("game");
    }
}
