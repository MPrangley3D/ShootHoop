using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public float timeUntilNextLevel = 0.0f;

    void Update()
    {
        if (timeUntilNextLevel > 0)
        {
            timeUntilNextLevel -= Time.deltaTime;
            if (timeUntilNextLevel <= 0)
            {
                LoadNextScene();
            }
        }
    }

    public void LoadNextScene()
    {
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentIndex + 1);
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
