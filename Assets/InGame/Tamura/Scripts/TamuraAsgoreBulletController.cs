using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>Asgoreの弾の動き</summary>
public class TamuraAsgoreBulletController : MonoBehaviour
{
    [Tooltip("弾のスピード")] private float _speed = 10;
    [SerializeField, Header("ビックリマークのゲームオブジェクト")] private Transform _exclamationMark = default;

    void Start()
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
            //一番上の親オブジェクトに伝える
            transform.root.gameObject.GetComponent<TamuraAsgoreController>().ChildrenCheck();
        }

    }

}