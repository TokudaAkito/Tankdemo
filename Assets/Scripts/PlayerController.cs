using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody _prb;
    [SerializeField] float _moveSpeed;

    private void Start()
    {
        _prb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Movement();
    }

    void Movement()
    {
        if (Input.GetKey(KeyCode.W))    //前進
        {
            _prb.velocity = transform.forward * _moveSpeed;
        }
        if (Input.GetKey(KeyCode.S))    //後退
        {
            _prb.velocity = -transform.forward * _moveSpeed;
        }
        if (Input.GetKey(KeyCode.D))    //右移動
        {
            _prb.velocity = transform.right * _moveSpeed;
        }
        if (Input.GetKey(KeyCode.A))    //左移動
        {
            _prb.velocity = -transform.right * _moveSpeed;
        }
    }
}
