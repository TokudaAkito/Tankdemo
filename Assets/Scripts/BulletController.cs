using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] float _moveSpeed = 3.0f;

    private void Update()
    {
        Move();   
    }

    void Move()
    {
        transform.position = transform.forward * _moveSpeed;
    }
}
