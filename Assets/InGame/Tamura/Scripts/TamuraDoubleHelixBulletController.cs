using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>��d�点��̒e�̓����@�㉺�ɓ������E�ǂ��炩�ɓ���</summary>
public class TamuraDoubleHelixBulletController : MonoBehaviour
{
    [Tooltip("���Ƃ��Ƃ̈ʒu")] private Vector2 _originPos;
    [SerializeField, Header("�n�܂�̎���(�x���@)")] private float _theta;
    [SerializeField, Header("�㑤���ǂ���")] private bool _isUpper = true;
    [SerializeField, Header("���ɍs�����ǂ���")] private bool _isGoingLeft = true;
    [Tooltip("�e�������͂₳")] private float _speed = 18;
    [SerializeField, Header("�e�I�u�W�F�N�g")] private TamuraDoubleHelixController _doubleHelix;

    void Start()
    {
        _originPos = gameObject.GetComponent<Transform>().position;
        _theta *= Mathf.Deg2Rad;
        Set();
    }

    private void OnDisable()
    {
        //���ɖ߂�
        //transform.position = _originPos;
    }

    private void OnEnable()
    {
        //Set();
    }

    IEnumerator MoveBullet()
    {
        //�������o�Ă�����s����
        if(gameObject.activeSelf)
        {
            transform.position = new Vector2(transform.position.x, _originPos.y + 1.5f * (_isUpper ? 1 : -1) * Mathf.Abs(Mathf.Sin(_theta)));
            yield return new WaitForSeconds(1 / 60f);
            _theta += 2*Mathf.PI / 60;
            StartCoroutine(MoveBullet());
        }

    }

    /// <summary>�e�����o���Ƃ��Ɏ��s����</summary>
    public void Set()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2((_isGoingLeft ? -1 : 1) * _speed, 0);
        StartCoroutine(MoveBullet());
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //�O�֏o����e�I�u�W�F�N�g�ɓ`����
        if (collision.gameObject.name == "Generator")
        {
            _doubleHelix.ChildrenCheck();
        }

    }

}
