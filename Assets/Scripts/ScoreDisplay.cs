using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    Text text;
    ScoreKeeper scorekeeper;

	// Use this for initialization
	void Start ()
    {
        text = GetComponent<Text>();
        scorekeeper = FindObjectOfType<ScoreKeeper>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        text.text = "SCORE: " + scorekeeper.score;
	}
}
