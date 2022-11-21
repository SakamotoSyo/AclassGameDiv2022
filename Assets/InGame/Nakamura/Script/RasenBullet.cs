using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class RasenBullet : MonoBehaviour
{
    [SerializeField, Header("弾幕の密度(th)")] private float _dis = 30f;
    float _th = 30.0f;
    [SerializeField, Header("弾幕を何個生成するか")] private int _maxBullets = 20;
    [SerializeField,Header("bulletのプレハブをセット")] GameObject _bullet;
    float _rad;
    [SerializeField] float cooltime = 2;
    [SerializeField] List<GameObject> _bullets = new();

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RasenPop());
    }

    IEnumerator RasenPop()
    {
        for (int i = 0; i < _bullets.Count; i++)
        {
            _rad = _th * Mathf.Deg2Rad;
            var sin = Mathf.Sin(_rad);
            var cos = Mathf.Cos(_rad);
            var pos = new Vector2(cos * 1, sin * 1);
            _bullets[i].SetActive(true);
            _bullets[i].transform.position = pos;
            _th += _dis;

            yield return new WaitForSeconds(cooltime);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
