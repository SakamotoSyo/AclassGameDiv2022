using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class SakamotoBulletCon: MonoBehaviour
{
    [SerializeField, Header("bullet�̈ړ�����")] SBulletDir _bulletDir;
    [SerializeField, Header("bullet�̑��x")] int _bulletSpeed = 5;
    [SerializeField] BulletObserver _bulletObserver;
    Rigidbody2D _rb2d;
    [SerializeField, Header("�x�N�g���̋���")] SVectorPower _vecPower;
    [Tooltip("�ǂ̕����ɔ�΂���")]
    bool[] _dirBool;
    [Tooltip("�͂����������")]
    Vector2[] _dirPower;
    [Tooltip("�͂������������ۑ����Ă������߂̕ϐ�")]
    Vector2 dir;
    FalseCount _falseCount;
    bool _isDamage;
    bool _isVisible;

    void Awake()
    {
        _dirPower = new Vector2[] { new Vector2(-1 * _vecPower.GetLeftVec, 0), new Vector2(1 * _vecPower.GetRightVec, 0),
            new Vector2(0, 1* _vecPower.GetTopVec), new Vector2(0, -1* _vecPower.GetBottomVec) };
        _rb2d = GetComponent<Rigidbody2D>();
        _falseCount = GetComponentInParent<FalseCount>();
    }

    // Update is called once per frame
    void Start()
    {
        _bulletObserver.OnNonActive += Test;
    }

    private void OnEnable()
    {
        _isVisible = false;
        _dirBool = new bool[] { _bulletDir.GetLeft, _bulletDir.GetRight, _bulletDir.GetUp, _bulletDir.GetDown };
        dir = Vector2.zero;
        for (int i = 0; i < _dirBool.Length; i++)
        {
            if (_dirBool[i])
            {
                dir += _dirPower[i];
            }
        }

        _rb2d.velocity = dir.normalized * _bulletSpeed;
    }

    private void Test()
    {
        transform.position = transform.parent.gameObject.transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out IDamage _damage) && !_isDamage)
        {
            _isDamage = true;
            _damage.AddDamage();
        }
        else if (collision.CompareTag("Wall") && !_isVisible)
        {
            _bulletObserver.AddNonActiveObj();
            _isVisible = true;
        }
    }
}

[System.Serializable]
class SBulletDir
{
    [SerializeField, Header("�����")] private bool _up = false;
    public bool GetUp => _up;
    [SerializeField, Header("������")] private bool _down = false;
    public bool GetDown => _down;
    [SerializeField, Header("�E����")] private bool _right = false;
    public bool GetRight => _right;
    [SerializeField, Header("������")] private bool _left = false;
    public bool GetLeft => _left;
}
[System.Serializable]
class SVectorPower
{
    [SerializeField, Header("������ɑ΂���x�N�g���̗�")] private float _topVec = 1;
    public float GetTopVec => _topVec;
    [SerializeField, Header("�������ɑ΂���x�N�g���̗�")] private float _bottomVec = 1;
    public float GetBottomVec => _bottomVec;
    [SerializeField, Header("�E�����ɑ΂���x�N�g���̗�")] private float _rightVec = 1;
    public float GetRightVec => _rightVec;
    [SerializeField, Header("�������ɑ΂���x�N�g���̗�")] private float _leftVec = 1;
    public float GetLeftVec => _leftVec;
}
