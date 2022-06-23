using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    public GameObject pauseCanvas;
    private void Start() 
    {
        pauseCanvas.SetActive(false);
    }
    private void Update() 
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            Time.timeScale = 0;
            pauseCanvas.SetActive(true);
        }    
    }

    public void ResumeGame()
    {
        pauseCanvas.SetActive(false);
        Time.timeScale = 1;
    }

    public void Quit()
    {
        SceneManager.LoadScene(0);
    }
}
