using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalseCount : MonoBehaviour
{
    public int ExitCounter = 0;
    [SerializeField,Header("íeñãÇÃëçêî")] private int _maxBullets;

    private void Update()
    {
        if (_maxBullets == ExitCounter)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnDisable()
    {
        ExitCounter = 0;
    }
}
