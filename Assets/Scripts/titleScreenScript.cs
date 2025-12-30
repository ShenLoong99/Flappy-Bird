using UnityEngine;
using UnityEngine.SceneManagement;

public class titleScreenScript : MonoBehaviour
{
    // This function is called when the Play button is clicked
    public void PlayGame()
    {
        // Load next scene in build order
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Optional: Quit button function
    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
