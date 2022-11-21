using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WabeBullets : MonoBehaviour
{
    [SerializeField, Header("íeñãÇÃñßìx(th)")] private float _dis = 30f;
    float _th = 30.0f;
    [SerializeField, Header("íeñãÇâΩå¬ê∂ê¨Ç∑ÇÈÇ©")] private int _maxBullets = 20;
    [SerializeField, Header("íeñãÇÃë¨ìx")] private int _speed = 10;
    float _rad;
    [SerializeField] float cooltime = 2;
    [SerializeField] List<GameObject> _bulletsList = new();
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wabe());
    }

    IEnumerator Wabe()
    {
        for (int i = 0; i < _bulletsList.Count; i++)
        {
            _rad = _th * Mathf.Deg2Rad;
            var pos = new Vector3(Mathf.Cos(_rad), Mathf.Sin(_rad), 0);
            _bulletsList[i].SetActive(true);
            _bulletsList[i].transform.position = gameObject.transform.position + pos;
            _bulletsList[i].GetComponent<Rigidbody2D>().velocity =
                _bulletsList[i].transform.forward.normalized * _speed;
            _th += _dis;
            yield return new WaitForSeconds(cooltime);
        }
    }
}
