using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    [SerializeField] int _speed = 10;
    Rigidbody2D _rb2d;
    FalseCount _falseCount;
    // Start is called before the first frame update
    void Start()
    {
        _falseCount = GetComponentInParent<FalseCount>();
        _rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        var ShotFoward = Vector3.Scale((transform.position), new Vector3(1, 1, 0)).normalized;
        _rb2d.velocity = ShotFoward * _speed;
    }

    private void OnDisable()
    {
        _falseCount.ExitCounter += 1;
    }
}
