using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _rotationSpeed;
    private float _verticalInput;

    void Start()
    {

    }

    void FixedUpdate()
    {
        //Get the user's vertical input
        _verticalInput = Input.GetAxis("Vertical");

        //Move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * _speed);

        //Tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right, Time.deltaTime * _rotationSpeed * _verticalInput);
    }
}
