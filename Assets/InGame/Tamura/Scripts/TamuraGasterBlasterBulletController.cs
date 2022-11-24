using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

/// <summary>
/// GasterBlasterの弾(線)の動き　最初に色がついて、だんだん薄くなっていく
/// </summary>
public class TamuraGasterBlasterBulletController : MonoBehaviour
{
    [SerializeField, Header("初期色")] private Color _startColor;
    [SerializeField, Header("フェードし始めるまでの時間")] private float _waitFadeTime = 0.5f;
    [SerializeField, Header("フェードにかかる時間")] private float _fadeTime = 2;

    /// <summary>弾を打ってる動き　ぱっと出てだんだん消えていく</summary>
    /// <returns></returns>
    public IEnumerator Shot()
    {
        gameObject.GetComponent<SpriteRenderer>().color = _startColor;
        yield return new WaitForSeconds(_waitFadeTime);
        gameObject.GetComponent<SpriteRenderer>().DOFade(0, _fadeTime).SetEase(Ease.Linear).SetAutoKill();
    }
}
