using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomlyMovingBullets : MonoBehaviour
{

    [SerializeField] Rigidbody2D _rb;
    [Header("�ŏ��ɒe�����b�i�ނ�")]
    [SerializeField] private float _startMove;
    [Header("�X�s�[�h")]
    [SerializeField] private float _speed = 1f;
    [Header("���b�������炱�̒e�������邩")]
    [SerializeField] private float _NonActiveTime;

    [Tooltip("���ł����p�x")]
    float _rad;
    Coroutine _cor;
    void Start()
    {
    }

    void Update()
    {
        
    }

    private void OnEnable()
    {
       _cor = StartCoroutine(StartMove());
    }

    private void OnDisable()
    {
        if (_cor != null) 
        {
            StopCoroutine(_cor);
            _speed = 2.5f;
        }
    }

    private void FixedUpdate()
    {
        _rb.velocity = new Vector2(Mathf.Cos(_rad), Mathf.Sin(_rad)) * _speed;
    }

    IEnumerator StartMove() 
    {
        
        yield return new WaitForSeconds(_startMove);
        _speed = 0;
        //�e
        yield return new WaitForSeconds(2.5f);
        //������\������
        var obj = ObjectPool.Instance.UseObject(transform.position, PoolObjectType.ReflectionWall);
        obj.GetComponent<ReflectedBullet>().ChangeRad(_rad / Mathf.Deg2Rad + 45);
        var obj2 = ObjectPool.Instance.UseObject(transform.position, PoolObjectType.ReflectionWall);
        obj2.GetComponent<ReflectedBullet>().ChangeRad(_rad / Mathf.Deg2Rad - 45);
        gameObject.SetActive(false);
    }

    public void ChangeRad(float num)
    {
        Debug.Log(num);
        _rad = num * Mathf.Deg2Rad;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out IDamage _damage))
        {
            _damage.AddDamage();
        }
    }

}
