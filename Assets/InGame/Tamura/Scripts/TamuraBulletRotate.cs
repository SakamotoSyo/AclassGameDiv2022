using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

/// <summary>TamuraBullet�������Ɖ���ĂĂق���</summary>
public class TamuraBulletRotate : MonoBehaviour
{
    [SerializeField, Header("1��]�ɂ����鎞��")] private float _rotateTime = 2.0f;
    [SerializeField, Header("���v���ɂ��邩�ǂ���")] private bool _isClockwise = false;

    void Start()
    {
        //�ŏ��Ƀ����_���ɂ�����Ɖ���ĂĂ��炤
        transform.rotation = Quaternion.Euler(0, 0, Random.Range(0, 360));
        RotateBullet();
    }

    private void OnDisable()
    {
        //��������~�߂�
        gameObject.transform.DOKill();
    }

    private void OnEnable()
    {
        //�o������
        RotateBullet();
    }

    public void RotateBullet()
    {
        //�����Ɖ���Ă�
        gameObject.transform.DOLocalRotate(new Vector3(0, 0, (_isClockwise ? -1 : 1) * 360), _rotateTime)
            .SetEase(Ease.Linear).SetRelative(true).SetLoops(-1, LoopType.Incremental).SetAutoKill();
    }

}
