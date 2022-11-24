using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>GasterBlasterをつかさどる</summary>
public class TamuraGasterBlasterController : MonoBehaviour
{
    [SerializeField, Header("子オブジェクト")] private TamuraGasterBlasterBulletController[] _blasters;
    [SerializeField, Header("ブラスターの起動間隔")] private float _blasterInterval = 0.5f;

    void Start()
    {
        StartCoroutine(BlasterStarting());
    }

    IEnumerator BlasterStarting()
    {

        for(int i  = 0; i < _blasters.Length; i++)
        {
            //Blaster 流す
            StartCoroutine(_blasters[i].Shot());
            yield return new WaitForSeconds(_blasterInterval);
        }

        yield return new WaitForSeconds(2.0f);
        gameObject.SetActive(false);
    }

}
