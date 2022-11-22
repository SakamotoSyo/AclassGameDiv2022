using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevolveCircleBullet : MonoBehaviour
{
    [Header("âEâÒÇËÇ©ç∂âÒÇËÇ©")]
    [SerializeField] bool _isLightTurn;
    private float _rad = 0;
    private float _dist = 0;

    private void OnDisable()
    {
        _dist = 0;
    }


    void FixedUpdate()
    {
        float x = transform.position.x + Mathf.Sin(_rad * Mathf.Deg2Rad) * _dist;
        float y = transform.position.y + Mathf.Cos(_rad * Mathf.Deg2Rad) * _dist;
        transform.position = new Vector3(x, y, 0);

        if (_isLightTurn)
        {
            _rad += 1f;
        }
        else 
        {
            _rad -= 1f;
        }
        

        _dist += 0.001f;
    }

    public void ChangeRad(float num)
    {
        _rad = num;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Wall")) 
        {
            gameObject.SetActive(false);
        }
    }
}
