using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    /// <summary>プレイヤーのrigidbody</summary>
    Rigidbody _prb;
    /// <summary>プレイヤーの進行方向</summary>
    private Vector3 _dir;
    /// <summary>プレイヤーの移動速度 </summary>
    [SerializeField] private float _moveSpeed;
    /// <summary>プレイヤーの回転</summary>
    private Quaternion _rotate;
    [SerializeField] private float _rotateSpeed;
    /// <summary>弾丸のプレハブ</summary>
    [SerializeField] GameObject _bullet = null;
    /// <summary>弾丸の発射位置</summary>
    [SerializeField] GameObject _leftMuzzle = null;
    [SerializeField] GameObject _rightMuzzle = null;

    private float _h, _v;
    private void Start()
    {
        _prb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        _h = Input.GetAxisRaw("Horizontal");
        _v = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        if (_h != 0 || _v != 0)
        {
            Vector2 velocity = new Vector2(_h, _v);
            Movement(velocity);
        }
        else
        {
            _dir = Vector3.zero;
            _rotate = this.transform.rotation;
        }

        if (Input.GetMouseButton(0))
        {
            FireL();
        }
        if (Input.GetMouseButton(1))
        {
            FireR();
        }
    }

    private void Movement(Vector2 vec)
    {
        //プレイヤーの移動方向を決める
        _dir = new Vector3(vec.x, 0, vec.y);
        _dir = Camera.main.transform.TransformDirection(_dir);
        _dir.y = 0; 
        _dir = _dir.normalized;

        if (_dir.magnitude > 0)
        {
            _rotate = Quaternion.LookRotation(_dir, Vector3.up);
        }
        transform.rotation = Quaternion.RotateTowards(transform.rotation, _rotate, _rotateSpeed);

        _prb.AddForce(_dir * _moveSpeed, ForceMode.Force);
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
