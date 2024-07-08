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
        if (Input.GetKey(KeyCode.W))    //ëOêi
        {
            _prb.velocity = transform.forward * _moveSpeed;
        }
        if (Input.GetKey(KeyCode.S))    //å„ëﬁ
        {
            _prb.velocity = -transform.forward * _moveSpeed;
        }
        if (Input.GetKey(KeyCode.D))    //âEà⁄ìÆ
        {
            _prb.velocity = transform.right * _moveSpeed;
        }
        if (Input.GetKey(KeyCode.A))    //ç∂à⁄ìÆ
        {
            _prb.velocity = -transform.right * _moveSpeed;
        }
    }
}
