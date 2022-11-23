using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TamuraFloweyController : MonoBehaviour
{
    [SerializeField, Header("子オブジェクトが動く速さ")] private float _speed = 2;
    [Tooltip("子オブジェクトの初期位置保存")] private Vector3 _childrenTransform;
    [Tooltip("子オブジェクトの数")] private int _children;
    [Tooltip("外へ出た子オブジェクトの数")] private int _outChildren = 0;

    void Start()
    {
        _children = gameObject.transform.childCount;

        //子オブジェクトを取ってきて、自分の方向へ加速度を与える
        for (int i = 0; i < _children; i++)
        {
            var child = gameObject.transform.GetChild(i);
            var a = child.position;
            //_childrenTransform[i] = new Vector3(a.x,a.y, 0);
            Vector2 vec = gameObject.transform.position - child.gameObject.transform.position;
            child.GetComponent<Rigidbody2D>().velocity = vec.normalized * _speed;
        }

    }

    public void ChildrenCheck()
    {
        //外に出た子オブジェクトの数を増やす
        _outChildren++;

        //すべての子オブジェクトが外に出たら自身を消す
        if (_children <= _outChildren)
        {
            //消す前に位置を元に戻したりしたい
            gameObject.SetActive(false);
        }
    }

}
