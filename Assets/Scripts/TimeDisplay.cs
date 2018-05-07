using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour
{
    Text text;
    LevelManager levelmanager;

    // Use this for initialization
    void Start()
    {
        text = GetComponent<Text>();
        levelmanager = FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "TIME: " + levelmanager.timeUntilNextLevel;
    }
}
