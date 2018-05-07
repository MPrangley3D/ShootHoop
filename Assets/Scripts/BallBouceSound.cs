using UnityEngine;
using System.Collections;

public class BallBouceSound : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        AudioSource source = GetComponent<AudioSource>();
        source.Play();
    }
}
