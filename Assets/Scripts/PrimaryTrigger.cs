using UnityEngine;
using System.Collections;

public class PrimaryTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        print("Triggered!");
        print(collider);
        SecondaryTrigger secondaryTrigger = GetComponentInChildren<SecondaryTrigger>();
        secondaryTrigger.ExpectCollider(collider);
    }
}
