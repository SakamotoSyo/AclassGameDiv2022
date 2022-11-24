using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>二重らせんの弾の動き　上下に動きつつ左右どちらかに動く</summary>
public class TamuraDoubleHelixBulletController : MonoBehaviour
{
    [Tooltip("もともとの位置")] private Vector2 _originPos;
    [SerializeField, Header("始まりの周期(度数法)")] private float _theta;
    [SerializeField, Header("上側かどうか")] private bool _isUpper = true;
    [SerializeField, Header("左に行くかどうか")] private bool _isGoingLeft = true;
    [Tooltip("弾が動くはやさ")] private float _speed = 18;
    [SerializeField, Header("親オブジェクト")] private TamuraDoubleHelixController _doubleHelix;

    void Start()
    {
        _originPos = gameObject.GetComponent<Transform>().position;
        _theta *= Mathf.Deg2Rad;
        Set();
    }

    private void OnDisable()
    {
        //元に戻す
        //transform.position = _originPos;
    }

    private void OnEnable()
    {
        //Set();
    }

    IEnumerator MoveBullet()
    {
        //自分が出てたら実行する
        if(gameObject.activeSelf)
        {
            transform.position = new Vector2(transform.position.x, _originPos.y + 1.5f * (_isUpper ? 1 : -1) * Mathf.Abs(Mathf.Sin(_theta)));
            yield return new WaitForSeconds(1 / 60f);
            _theta += 2*Mathf.PI / 60;
            StartCoroutine(MoveBullet());
        }

    }

    /// <summary>弾幕を出すときに実行する</summary>
    public void Set()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2((_isGoingLeft ? -1 : 1) * _speed, 0);
        StartCoroutine(MoveBullet());
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //外へ出たら親オブジェクトに伝える
        if (collision.gameObject.name == "Generator")
        {
            _doubleHelix.ChildrenCheck();
        }

    }

}
