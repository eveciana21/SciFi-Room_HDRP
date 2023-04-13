using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private float _speed = 3f;
    private float _rotateSpeed = 40;

    void Start()
    {
        transform.position = new Vector3(0, 1.75f, -14);
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    void Update()
    {
        ControlMovement();
    }

    private void ControlMovement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * _speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(-Vector3.up * _rotateSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * _rotateSpeed * Time.deltaTime);
        }
    }


}
