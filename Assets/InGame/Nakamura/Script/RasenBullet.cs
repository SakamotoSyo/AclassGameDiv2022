using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class RasenBullet : MonoBehaviour
{
    [SerializeField, Header("íeñãÇÃñßìx(th)")] private float _dis = 30f;
    float _th = 0.0f;
    [SerializeField, Header("íeñãÇâΩå¬ê∂ê¨Ç∑ÇÈÇ©")] private int _maxBullets = 20;
    [SerializeField, Header("íeñãÇÃë¨ìx")] private int _speed = 10;
    float _rad;
    [SerializeField] float cooltime = 2;
    [SerializeField] List<GameObject> _bullets = new();

    // Start is called before the first frame update
    private void OnEnable()
    {
        StartCoroutine(RasenPop());
    }

    IEnumerator RasenPop()
    {
        for (int i = 0; i < _bullets.Count; i++)
        {
            _rad = _th * Mathf.Deg2Rad;
            var pos = new Vector3(Mathf.Cos(_rad), Mathf.Sin(_rad), 0);
            _bullets[i].SetActive(true);

            if (!_bullets[i].TryGetComponent<BulletControlle>(out BulletControlle bullet))
            {
                _bullets[i].transform.position = gameObject.transform.position + pos;
                _bullets[i].GetComponent<Rigidbody2D>().velocity = pos * _speed;
                _th += _dis;
            }
            else
            {
                _bullets[i].transform.position = gameObject.transform.position;
            }
            yield return new WaitForSeconds(cooltime);
        }
    }
}
