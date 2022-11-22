using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneScript : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rb;
    [SerializeField] float _purasu;
    [Header("横に進むスピード")]
    [SerializeField] float _speedX = 0.001f;
     Vector3 _position;
    void Start()
    {
        
    }

    private void OnEnable()
    {
        _position = transform.position;
    }

    void Update()
    {
        _speedX += 0.003f;
        var a = Mathf.Sin(_speedX);
        var b = Mathf.Tan(_speedX);

        transform.Rotate(0, 0, 10);

        transform.position = _position +new Vector3(a , b * -1, 0);
    }
}
