using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

/// <summary>TamuraBullet‚ª‚¸‚Á‚Æ‰ñ‚Á‚Ä‚Ä‚Ù‚µ‚¢</summary>
public class TamuraBulletRotate : MonoBehaviour
{
    [SerializeField, Header("1‰ñ“]‚É‚©‚©‚éŠÔ")] private float _rotateTime = 2.0f;
    [SerializeField, Header("Œv‰ñ‚è‚É‚·‚é‚©‚Ç‚¤‚©")] private bool _isClockwise = false;

    void Start()
    {
        //Å‰‚Éƒ‰ƒ“ƒ_ƒ€‚É‚¿‚å‚Á‚Æ‰ñ‚Á‚Ä‚Ä‚à‚ç‚¤
        transform.rotation = Quaternion.Euler(0, 0, Random.Range(0, 360));
        RotateBullet();
    }

    private void OnDisable()
    {
        //Á‚¦‚½‚ç~‚ß‚é
        gameObject.transform.DOKill();
    }

    private void OnEnable()
    {
        //o‚½‚ç‰ñ‚é
        RotateBullet();
    }

    public void RotateBullet()
    {
        //‚¸‚Á‚Æ‰ñ‚Á‚Ä‚é
        gameObject.transform.DOLocalRotate(new Vector3(0, 0, (_isClockwise ? -1 : 1) * 360), _rotateTime)
            .SetEase(Ease.Linear).SetRelative(true).SetLoops(-1, LoopType.Incremental).SetAutoKill();
    }

}
