using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    /// <summary>�v���C���[��rigidbody</summary>
    Rigidbody _prb;
    /// <summary>�v���C���[�̈ړ����x </summary>
    [SerializeField] float _moveSpeed;
    /// <summary>�e�ۂ̃v���n�u</summary>
    [SerializeField] GameObject _bullet = null;
    /// <summary>�e�ۂ̔��ˈʒu</summary>
    [SerializeField] GameObject _leftMuzzle = null;
    [SerializeField] GameObject _rightMuzzle = null;
    private void Start()
    {
        _prb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Movement();
        if (Input.GetMouseButton(0))
        {
            FireL();
        }
        if (Input.GetMouseButton(1))
        {
            FireR();
        }
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

    void FireL()
    {
        if (_bullet && _leftMuzzle)
        {
            GameObject bullets = Instantiate(_bullet, _leftMuzzle.transform.position, _leftMuzzle.transform.rotation);
        }
    }

    void FireR()
    {
        if (_bullet && _rightMuzzle)
        {
            GameObject bullets = Instantiate(_bullet, _rightMuzzle.transform.position, _rightMuzzle.transform.rotation);
        }
    }
}
