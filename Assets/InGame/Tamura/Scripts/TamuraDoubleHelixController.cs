using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TamuraDoubleHelixController : MonoBehaviour
{
    [Tooltip("子オブジェクトの数")] private int _children = 24 * 2;
    [Tooltip("外へ出た子オブジェクトの数")] private int _outChildren = 0;

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
