using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

/// <summary>
/// �r�b�N���}�[�N���ԂƉ��F�ɂ�����������
/// </summary>
public class TamuraAsgoreWarning : MonoBehaviour
{
    [SerializeField, Header("���Ƃ��Ƃ̐F")] private Color _firstColor = Color.yellow;
    [SerializeField, Header("�ω�����F")] private Color _secondColor = Color.red;
    [SerializeField, Header("�ω�����܂ł̎���")] private float _changeTime = 0.1f;

    void Start()
    {
        StartCoroutine(ColorChange());
    }

    private void OnEnable()
    {
        StartCoroutine(ColorChange());
    }

    /// <summary>�F�����݂ɕς���</summary>
    /// <returns></returns>
    IEnumerator ColorChange()
    {
        var color = gameObject.GetComponent<SpriteRenderer>();

        //���g���������͐F��ς�������
        while(gameObject.activeSelf)
        {
            color.color = _firstColor;
            //AsgoreWarning�@����
            yield return new WaitForSeconds(_changeTime);
            color.color = _secondColor;
            //AsgoreWarning�@����
            yield return new WaitForSeconds(_changeTime);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //�e�����������玩��������
        if(collision.gameObject.CompareTag("Bullet"))
        {
            //AsgoreBullet�@����
            gameObject.SetActive(false);
        }

    }

}
