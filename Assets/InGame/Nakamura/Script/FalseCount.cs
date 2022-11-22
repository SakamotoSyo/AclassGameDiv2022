using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalseCount : MonoBehaviour
{
    [SerializeField] private int _counter = 0;
    public int ExitCounter
    {
        set
        {
            _counter = value;
        }
        get
        {
            return _counter;
        }
    }
    [SerializeField,Header("íeñãÇÃëçêî")] private int _maxBullets;

    private void Update()
    {
        if (_maxBullets <= ExitCounter)
        {
            gameObject.SetActive(false);
        }
    }
    private void OnDisable()
    {
        _counter = 0;
        ExitCounter = 0;
    }
}
