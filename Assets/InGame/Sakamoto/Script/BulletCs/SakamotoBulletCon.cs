using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class SakamotoBulletCon: MonoBehaviour
{
    [SerializeField, Header("bulletの移動方向")] SBulletDir _bulletDir;
    [SerializeField, Header("bulletの速度")] int _bulletSpeed = 5;
    [SerializeField] BulletObserver _bulletObserver;
    Rigidbody2D _rb2d;
    [SerializeField, Header("ベクトルの強さ")] SVectorPower _vecPower;
    [Tooltip("どの方向に飛ばすか")]
    bool[] _dirBool;
    [Tooltip("力をかける方向")]
    Vector2[] _dirPower;
    [Tooltip("力をかける方向を保存しておくための変数")]
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
    [SerializeField, Header("上方向")] private bool _up = false;
    public bool GetUp => _up;
    [SerializeField, Header("下方向")] private bool _down = false;
    public bool GetDown => _down;
    [SerializeField, Header("右方向")] private bool _right = false;
    public bool GetRight => _right;
    [SerializeField, Header("左方向")] private bool _left = false;
    public bool GetLeft => _left;
}
[System.Serializable]
class SVectorPower
{
    [SerializeField, Header("上方向に対するベクトルの力")] private float _topVec = 1;
    public float GetTopVec => _topVec;
    [SerializeField, Header("下方向に対するベクトルの力")] private float _bottomVec = 1;
    public float GetBottomVec => _bottomVec;
    [SerializeField, Header("右方向に対するベクトルの力")] private float _rightVec = 1;
    public float GetRightVec => _rightVec;
    [SerializeField, Header("左方向に対するベクトルの力")] private float _leftVec = 1;
    public float GetLeftVec => _leftVec;
}
