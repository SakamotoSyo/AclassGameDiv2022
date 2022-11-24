using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

/// <summary>
/// GasterBlaster�̒e(��)�̓����@�ŏ��ɐF�����āA���񂾂񔖂��Ȃ��Ă���
/// </summary>
public class TamuraGasterBlasterBulletController : MonoBehaviour
{
    [SerializeField, Header("�����F")] private Color _startColor;
    [SerializeField, Header("�t�F�[�h���n�߂�܂ł̎���")] private float _waitFadeTime = 0.5f;
    [SerializeField, Header("�t�F�[�h�ɂ����鎞��")] private float _fadeTime = 2;

    /// <summary>�e��ł��Ă铮���@�ς��Əo�Ă��񂾂�����Ă���</summary>
    /// <returns></returns>
    public IEnumerator Shot()
    {
        gameObject.GetComponent<SpriteRenderer>().color = _startColor;
        yield return new WaitForSeconds(_waitFadeTime);
        gameObject.GetComponent<SpriteRenderer>().DOFade(0, _fadeTime).SetEase(Ease.Linear).SetAutoKill();
    }
}
