using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevolveCircleGenerate : MonoBehaviour
{
    [Header("âΩïbÇ±ÇÃíeñãÇ™è¡Ç¶ÇÈÇ©")]
    [SerializeField] float _nonActiveTime;
    [SerializeField] GameObject _gameObject;
    [SerializeField] GameObject _gameObject2;

    [Header("ë“ã@éûä‘")]
    [SerializeField] float _waitTime;

    Coroutine _generaetCor;
    WaitForSeconds _corWaitTime;

    private void Start()
    {
        _corWaitTime = new WaitForSeconds(_waitTime);
    }

    private void OnEnable() 
    {
       _generaetCor = StartCoroutine(Generate());
        StartCoroutine(NonActiveCor());
    }

    private void OnDisable()
    {
        if (_generaetCor != null) 
        {
            StopCoroutine(_generaetCor);
        }
    }

    IEnumerator Generate()
    {
        while (true)
        {
            AudioManager.Instance.PlaySound(SoundPlayType.Shot);
            for (int rad = 0; rad < 360; rad += 40)
            {
                var Obj = ObjectPool.Instance.UseObject(transform.position, PoolObjectType.RightRevolveCircle);
                Obj.GetComponent<RevolveCircleBullet>().ChangeRad(rad);
                var Obj2 = ObjectPool.Instance.UseObject(transform.position, PoolObjectType.LeftRevolveCircle);
                Obj2.GetComponent<RevolveCircleBullet>().ChangeRad(rad);
            }
            yield return _corWaitTime;
        }
    }

    IEnumerator NonActiveCor() 
    {
        yield return new WaitForSeconds(_nonActiveTime);
        gameObject.SetActive(false);
    }

}
