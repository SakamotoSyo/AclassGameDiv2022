using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

/// <summary>TamuraBullet‚ª‚¸‚Á‚Æ‰ñ‚Á‚Ä‚Ä‚Ù‚µ‚¢</summary>
public class TamuraBulletRotate : MonoBehaviour
{
    [SerializeField, Header("1‰ñ“]‚É‚©‚©‚éŽžŠÔ")] private float _rotateTime = 2.0f;
    [SerializeField, Header("ŽžŒv‰ñ‚è‚É‚·‚é‚©‚Ç‚¤‚©")] private bool _isClockwise = false;

    void Start()
    {
        transform.rotation = Quaternion.Euler(0, 0, Random.Range(0, 360));
        //‚¸‚Á‚Æ‰ñ‚Á‚Ä‚é
        gameObject.transform.DOLocalRotate(new Vector3(0, 0, (_isClockwise ? -1 : 1) * 360), _rotateTime)
            .SetEase(Ease.Linear).SetRelative(true).SetLoops(-1, LoopType.Incremental);
    }

}
