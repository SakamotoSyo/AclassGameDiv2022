using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReflectedBullet : MonoBehaviour
{
    [SerializeField] private Renderer _renderer;
    [SerializeField] private Rigidbody2D _body2D;
    [Header("進むスピード")]
    [SerializeField] private float _speed;
    Vector2 _normal;
    private float _rad;
    bool _isTest;
    bool isReflrct = false;

    void Update()
    {
        if (isReflrct)
        {
            _body2D.velocity = Vector2.Reflect(new Vector2(Mathf.Cos(_rad), Mathf.Sin(_rad)), _normal);
        }
        else 
        {
            _body2D.velocity = new Vector2(Mathf.Cos(_rad), Mathf.Sin(_rad));
        }
        
    }

    public void ChangeRad(float num)
    {
        _rad = num * Mathf.Rad2Deg;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _normal = collision.contacts[0].normal;
        if (collision.gameObject.CompareTag("Reflect"))
        {
            _normal = collision.contacts[0].normal;
            isReflrct = !isReflrct;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out IDamage _damage))
        {
            _damage.AddDamage();
        }
    }

}
