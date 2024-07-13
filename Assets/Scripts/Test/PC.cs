using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC : MonoBehaviour
{
    Rigidbody _rb;
    //ˆÚ“®•ûŒü
    private Vector3 _d;
    //ˆÚ“®‘¬“x
    private float _speed = 10.0f;
    private float _jSpeed = 5.0f;
    //Axis
    private float _h, _v;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        _h = Input.GetAxis("Horizontal");
        _v = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        if (_h != 0f || _v != 0f)
        {
            Move();
        }
        else
        {
            transform.position = this.transform.position;
        }
    }

    void Move()
    {
        _rb.velocity = new Vector3(_h * _speed, 0f, _v * _speed);

        if (Input.GetKey(KeyCode.Space))
        {
            _rb.velocity = new Vector3(0f, 10f, 0f);
        }
    }
}
