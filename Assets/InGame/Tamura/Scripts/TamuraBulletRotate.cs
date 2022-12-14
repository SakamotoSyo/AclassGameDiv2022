using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

/// <summary>TamuraBulletがずっと回っててほしい</summary>
public class TamuraBulletRotate : MonoBehaviour
{
    [SerializeField, Header("1回転にかかる時間")] private float _rotateTime = 2.0f;
    [SerializeField, Header("時計回りにするかどうか")] private bool _isClockwise = false;

    void Start()
    {
        //最初にランダムにちょっと回っててもらう
        transform.rotation = Quaternion.Euler(0, 0, Random.Range(0, 360));
        RotateBullet();
    }

    private void OnDisable()
    {
        //消えたら止める
        gameObject.transform.DOKill();
    }

    private void OnEnable()
    {
        //出たら回る
        RotateBullet();
    }

    public void RotateBullet()
    {
        //ずっと回ってる
        gameObject.transform.DOLocalRotate(new Vector3(0, 0, (_isClockwise ? -1 : 1) * 360), _rotateTime)
            .SetEase(Ease.Linear).SetRelative(true).SetLoops(-1, LoopType.Incremental).SetAutoKill();
    }

}
