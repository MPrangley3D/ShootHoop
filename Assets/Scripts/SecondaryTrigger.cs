using UnityEngine;
using System.Collections;

public class SecondaryTrigger : MonoBehaviour
{
    Collider expectedCollider;
    public int points = 1;

    public void ExpectCollider(Collider collider)
    {
        expectedCollider = collider;
    }
    void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider == expectedCollider)
        {
            ScoreKeeper scorekeeper = FindObjectOfType<ScoreKeeper>();
            scorekeeper.IncrementScore(points);
            AudioSource source = GetComponent<AudioSource>();
            source.Play();
        }
    }
}
