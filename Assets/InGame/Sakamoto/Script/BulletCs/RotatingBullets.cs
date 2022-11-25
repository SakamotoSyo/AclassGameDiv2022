using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingBullets: MonoBehaviour
{
    [Header("âΩïbÇ±ÇÃíeñãÇ™è¡Ç¶ÇÈÇ©")]
    [SerializeField] float _nonActiveTime;
    [SerializeField] GameObject _gameObject;
    [SerializeField] GameObject _gameObject2;

    [Header("ë“ã@éûä‘")]
    [SerializeField] float _waitTime;

    Coroutine _generaetCor;
    WaitForSeconds _corWaitTime;
    int _rad; 

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
        StopCoroutine(_generaetCor);
    }

    IEnumerator Generate()
    {
        while (true)
        {
            AudioManager.Instance.PlaySound(SoundPlayType.Shot);
            _rad += 5;
            for (int rad = 0; rad < 360; rad += 40)
            {
                var Obj = ObjectPool.Instance.UseObject(transform.position, PoolObjectType.RightRevolveCircle);
                Obj.GetComponent<RevolveCircleBullet>().ChangeRad(rad+ _rad);
                //var Obj2 = ObjectPool.Instance.UseObject(transform.position, PoolObjectType.LeftRevolveCircle);
                //Obj2.GetComponent<RevolveCircleBullet>().ChangeRad(rad + _rad);
            }

            if (_rad >= 359) 
            {
                _rad = 0;
            }
            yield return _corWaitTime;
        }
    }

    IEnumerator NonActiveCor()
    {
        yield return new WaitForSeconds(_nonActiveTime);
        gameObject.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out IDamage _damage))
        {
            _damage.AddDamage();
        }
    }
}