using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TamuraFloweyController : MonoBehaviour
{
    [SerializeField, Header("�q�I�u�W�F�N�g����������")] private float _speed = 2;
    [Tooltip("�q�I�u�W�F�N�g�̐�")] private int _children;
    [Tooltip("�O�֏o���q�I�u�W�F�N�g�̐�")] private int _outChildren = 0;

    void Start()
    {
        _children = gameObject.transform.childCount;
        Set();
    }

    private void OnEnable()
    {
        //Set();
    }

    /// <summary>�e�����Ăяo���ꂽ�Ƃ��ɍs������</summary>
    public void Set()
    {
        //�q�I�u�W�F�N�g������Ă��āA�����̕����։����x��^����
        for (int i = 0; i < _children; i++)
        {
            var child = gameObject.transform.GetChild(i);
            Vector2 vec = gameObject.transform.position - child.gameObject.transform.position;
            child.GetComponent<Rigidbody2D>().velocity = vec.normalized * _speed;
        }

    }

    private void OnDisable()
    {
        _outChildren = 0;
    }

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
