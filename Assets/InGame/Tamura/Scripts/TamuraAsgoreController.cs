using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TamuraAsgoreController : MonoBehaviour
{
    [Tooltip("�q�I�u�W�F�N�g�̐�")] private int _children = 6*2*4*2;
    [Tooltip("�O�֏o���q�I�u�W�F�N�g�̐�")] private int _outChildren = 0;

    public void ChildrenCheck()
    {
        //�O�ɏo���q�I�u�W�F�N�g�̐��𑝂₷
        _outChildren++;

        //���ׂĂ̎q�I�u�W�F�N�g���O�ɏo���玩�g������
        if (_children <= _outChildren)
        {
            //�����O�Ɉʒu�����ɖ߂����肵����
            gameObject.SetActive(false);
        }
    }

}
