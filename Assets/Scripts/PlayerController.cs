using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    /// <summary>プレイヤーのrigidbody</summary>
    Rigidbody _prb;
    /// <summary>プレイヤーの移動速度 </summary>
    [SerializeField] float _moveSpeed;
    /// <summary>弾丸のプレハブ</summary>
    [SerializeField] GameObject _bullet = null;
    /// <summary>弾丸の発射位置</summary>
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
