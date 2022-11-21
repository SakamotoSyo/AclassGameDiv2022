using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BulletControlle : MonoBehaviour
{
    [SerializeField,Header("bulletの移動方向")] BulletDir _bulletDir;
    [SerializeField, Header("bulletの速度")] int _bulletSpeed = 5;
    Rigidbody2D _rb2d;
    [SerializeField, Header("ベクトルの強さ")] VectorPower _vecPower;
    [Tooltip("どの方向に飛ばすか")]
    bool[] _dirBool;
    [Tooltip("力をかける方向")]
    Vector2[] _dirPower;
    [Tooltip("力をかける方向を保存しておくための変数")]
    Vector2 dir;
    FalseCount _falseCount;
    
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

    private void OnDisable()
    {
        _falseCount.ExitCounter += 1;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out IDamage _damage))
        {
            _damage.AddDamage();
        }
    }
}

[System.Serializable]
class BulletDir
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
class VectorPower
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
