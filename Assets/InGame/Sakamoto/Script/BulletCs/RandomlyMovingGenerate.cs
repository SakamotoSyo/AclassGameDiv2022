using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomlyMovingGenerate : MonoBehaviour
{
    [Header("���b���̐����҂������邩")]
    [SerializeField] float _nonActiveTime;
    [SerializeField] GameObject _bullet;

    [Header("�e�𐶐�����Ԃ̎���")]
    [SerializeField] float _waitTime;

    Coroutine _generaetCor;
    WaitForSeconds _corWaitTime;

    private void Start()
    {
        _generaetCor = StartCoroutine(Generate());
        StartCoroutine(NonActiveCor());
        _corWaitTime = new WaitForSeconds(_waitTime);
    }

    private void OnEnable()
    {
       
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
            AudioManager.Instance.PlaySound(SoundPlayType.Shot);
            for (int rad = 0; rad < 360; rad += 40)
            {
                var Obj = ObjectPool.Instance.UseObject(transform.position, PoolObjectType.SplitShell);
                Obj.GetComponent<RandomlyMovingBullets>().ChangeRad(rad);
       �@�@     yield return _corWaitTime;
            }
    }

    IEnumerator NonActiveCor()
    {
        yield return new WaitForSeconds(_nonActiveTime);
        gameObject.SetActive(false);
    }

}
