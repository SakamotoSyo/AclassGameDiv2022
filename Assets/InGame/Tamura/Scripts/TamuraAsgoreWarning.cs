using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

/// <summary>
/// ビックリマークが赤と黄色にちかちかする
/// </summary>
public class TamuraAsgoreWarning : MonoBehaviour
{
    [SerializeField, Header("もともとの色")] private Color _firstColor = Color.yellow;
    [SerializeField, Header("変化する色")] private Color _secondColor = Color.red;
    [SerializeField, Header("変化するまでの時間")] private float _changeTime = 0.1f;

    void Start()
    {
        StartCoroutine(ColorChange());
    }

    private void OnEnable()
    {
        StartCoroutine(ColorChange());
    }

    /// <summary>色を交互に変える</summary>
    /// <returns></returns>
    IEnumerator ColorChange()
    {
        var color = gameObject.GetComponent<SpriteRenderer>();

        //自身がいる限りは色を変え続ける
        while(gameObject.activeSelf)
        {
            color.color = _firstColor;
            //AsgoreWarning　流す
            yield return new WaitForSeconds(_changeTime);
            color.color = _secondColor;
            //AsgoreWarning　流す
            yield return new WaitForSeconds(_changeTime);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //弾が当たったら自分を消す
        if(collision.gameObject.CompareTag("Bullet"))
        {
            //AsgoreBullet　流す
            gameObject.SetActive(false);
        }

    }

}
