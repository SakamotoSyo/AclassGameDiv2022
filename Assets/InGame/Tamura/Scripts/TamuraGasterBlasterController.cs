using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>GasterBlaster�������ǂ�</summary>
public class TamuraGasterBlasterController : MonoBehaviour
{
    [SerializeField, Header("�q�I�u�W�F�N�g")] private TamuraGasterBlasterBulletController[] _blasters;
    [SerializeField, Header("�u���X�^�[�̋N���Ԋu")] private float _blasterInterval = 0.5f;

    void Start()
    {
        StartCoroutine(BlasterStarting());
    }

    IEnumerator BlasterStarting()
    {

        for(int i  = 0; i < _blasters.Length; i++)
        {
            //Blaster ����
            StartCoroutine(_blasters[i].Shot());
            yield return new WaitForSeconds(_blasterInterval);
        }

        yield return new WaitForSeconds(2.0f);
        gameObject.SetActive(false);
    }

}
