using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>Asgore�̒e�̓���</summary>
public class TamuraAsgoreBulletController : MonoBehaviour
{
    [Tooltip("�e�̃X�s�[�h")] private float _speed = 10;
    [SerializeField, Header("�r�b�N���}�[�N�̃Q�[���I�u�W�F�N�g")] private Transform _exclamationMark = default;

    void Start()
    {
        //�������r�b�N���}�[�N����ɂ����牺�ɁA���ɂ������ɉ����x��^����
        gameObject.GetComponent<Rigidbody2D>().velocity 
            = new Vector2(0, (_exclamationMark.position.y - transform.position.y < 0 ? -1 : 1) * _speed);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //�O�֏o����e�I�u�W�F�N�g�ɓ`����
        if (collision.gameObject.name == "Generator")
        {
            //��ԏ�̐e�I�u�W�F�N�g�ɓ`����
            transform.root.gameObject.GetComponent<TamuraAsgoreController>().ChildrenCheck();
        }

    }

}