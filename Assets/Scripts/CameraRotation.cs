using UnityEngine;
using System.Collections;

public class CameraRotation : MonoBehaviour
{
    public float walkspeed = 0.5f;
	// Use this for initialization
	void Start ()
    {
	}
	
	// Update is called once per frame
	void Update ()
    {
        float rotationSpeed = 5.0f;
        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed;

        transform.localRotation = Quaternion.Euler(0, mouseX, 0) * transform.localRotation;
        Camera camera = GetComponentInChildren<Camera>();
        camera.transform.localRotation = Quaternion.Euler(-mouseY, 0, 0) * camera.transform.localRotation;


        if (Input.GetKey(KeyCode.W))
        {
            transform.position += camera.transform.rotation * Vector3.forward;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += camera.transform.rotation*Vector3.left;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += camera.transform.rotation*Vector3.back;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += camera.transform.rotation*Vector3.right;
        }



    }
}
