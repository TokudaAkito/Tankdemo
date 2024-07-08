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
        if (Input.GetKey(KeyCode.W))    //�O�i
        {
            _prb.velocity = transform.forward * _moveSpeed;
        }
        if (Input.GetKey(KeyCode.S))    //���
        {
            _prb.velocity = -transform.forward * _moveSpeed;
        }
        if (Input.GetKey(KeyCode.D))    //�E�ړ�
        {
            _prb.velocity = transform.right * _moveSpeed;
        }
        if (Input.GetKey(KeyCode.A))    //���ړ�
        {
            _prb.velocity = -transform.right * _moveSpeed;
        }
    }
}
