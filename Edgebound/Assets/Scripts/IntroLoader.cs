using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroLoader : MonoBehaviour
{
    public float splashTime = 15f; // Tiempo en segundos que dura el splash
    public string nextScene = "MainMenuScene"; // Nombre de la escena siguiente

    void Start()
    {
        Invoke("LoadNextScene", splashTime); // Espera y luego cambia
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene(nextScene);
    }
}
