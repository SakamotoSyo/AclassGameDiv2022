using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BulletControlle : MonoBehaviour
{
    [SerializeField,Header("bulletの移動方向")] BulletDir _bulletDir;
    [SerializeField, Header("bulletの速度")] int _bulletSpeed = 5;
    Rigidbody2D _rb2d;
    float _upVector = 1;
    float _downVector = -1;
    float _rightVector = 1;
    float _leftVector = -1;
    // Start is called before the first frame update
    void Awake()
    {
        _rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Start()
    {
        if (_bulletDir.GetUp)
        {
            if (_bulletDir.GetLeft)
            {
                _rb2d.velocity = new Vector2(_leftVector, _upVector).normalized * _bulletSpeed;
            }
            else if (_bulletDir.GetRight)
            {
                _rb2d.velocity = new Vector2(_rightVector, _upVector).normalized * _bulletSpeed;
            }
            else
            {
                _rb2d.velocity = new Vector2(0, _upVector).normalized * _bulletSpeed;
            }
        }
        else if (_bulletDir.GetDown)
        {
            if (_bulletDir.GetLeft)
            {
                _rb2d.velocity = new Vector2(_leftVector, _downVector).normalized * _bulletSpeed;
            }
            else if (_bulletDir.GetRight)
            {
                _rb2d.velocity = new Vector2(_rightVector, _downVector).normalized * _bulletSpeed;
            }
            else
            {
                _rb2d.velocity = new Vector2(0, _downVector).normalized * _bulletSpeed;
            }
        }
        else if (_bulletDir.GetRight)
        {
            _rb2d.velocity = new Vector2(_rightVector, 0).normalized * _bulletSpeed;
        }
        else if (_bulletDir.GetLeft)
        {
            _rb2d.velocity = new Vector2(_leftVector, 0).normalized * _bulletSpeed;
        }
        else
        {
            _rb2d.velocity = new Vector2(0, 0) * _bulletSpeed;
        }
    }
}

[System.Serializable]
class BulletDir
{
    [SerializeField, Header("上方向")] private bool _up = false;
    public bool GetUp
    {
        set
        {
            _up = value;
        }
        get
        {
            return _up;
        }
    }
    [SerializeField, Header("下方向")] private bool _down = false;
    public bool GetDown
    {
        set
        {
            _down = value;
        }
        get
        {
            return _down;
        }
    }
    [SerializeField, Header("右方向")] private bool _right = false;
    public bool GetRight
    {
        set
        {
            _right = value;
        }
        get
        {
            return _right;
        }
    }
    [SerializeField, Header("左方向")] private bool _lleft = false;
    public bool GetLeft
    {
        set
        {
            _lleft = value;
        }
        get
        {
            return _lleft;
        }
    }
}
