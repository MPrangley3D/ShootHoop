using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour
{
    public int score = 0;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void IncrementScore(int points)
    {
        score += points;
        print("Score: "+score);
    }
}
