using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>Asgoreの弾の動き</summary>
public class TamuraAsgoreBulletController : MonoBehaviour
{
    [Tooltip("弾のスピード")] private float _speed = 15;
    [SerializeField, Header("ビックリマークのゲームオブジェクト")] private Transform _exclamationMark = default;
    [SerializeField, Header("親オブジェクト(Asgore)")] private TamuraAsgoreController _asgore = default;
    [Tooltip("もともとの位置")] private Vector2 _originPos;

    void Start()
    {
        //_originPos = gameObject.GetComponent<Transform>().position;
        Set();
    }

    private void OnEnable()
    {
        //Set();
    }

    private void OnDisable()
    {
        //元の位置に戻す
        //transform.position = _originPos;
    }

    /// <summary>この弾幕が呼び出されたときに行う</summary>
    public void Set()
    {        
        //自分がビックリマークより上にいたら下に、下にいたら上に加速度を与える
        gameObject.GetComponent<Rigidbody2D>().velocity
            = new Vector2(0, (_exclamationMark.position.y - transform.position.y < 0 ? -1 : 1) * _speed);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //外へ出たら親オブジェクトに伝える
        if (collision.gameObject.name == "Generator")
        {
            _asgore.ChildrenCheck();
        }

    }    

}