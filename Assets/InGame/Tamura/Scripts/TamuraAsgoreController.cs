using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TamuraAsgoreController : MonoBehaviour
{
    [Tooltip("子オブジェクトの数")] private int _children = 6*2*4*2;
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
