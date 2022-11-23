using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletObserver : MonoBehaviour
{
    private int _nonActiveObj = 0;
    public System.Action OnNonActive;

    private float _rotate;

    private void OnDisable()
    {
        _nonActiveObj = 0;
        transform.rotation = Quaternion.identity;
    }

    private void OnEnable()
    {
       _rotate = Random.Range(0.3f, 1.1f);
    }

    private void FixedUpdate()
    {
        transform.Rotate(0, 0, 1f);
    }

    public void AddNonActiveObj()
    {
        _nonActiveObj++;
        if (_nonActiveObj >= transform.childCount) 
        {
            OnNonActive();
            gameObject.SetActive(false);
        }
    }
}
