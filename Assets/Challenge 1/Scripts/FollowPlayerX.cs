using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    [Header("GameObject:")]
    public GameObject Plane;

    //Private Variable
    private Vector3 _offset = new Vector3(22.25f, 2.25f, 1);

    void Start()
    {

    }

    void Update()
    {
        transform.position = Plane.transform.position + _offset;
    }
}
