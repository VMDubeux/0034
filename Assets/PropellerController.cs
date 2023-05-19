using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerController : MonoBehaviour
{
    [SerializeField] private float _speedPropeller;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(Vector3.forward, Time.deltaTime * _speedPropeller);
    }
}
