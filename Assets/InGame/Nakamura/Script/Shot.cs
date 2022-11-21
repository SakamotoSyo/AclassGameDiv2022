using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    FalseCount _falseCount;
    // Start is called before the first frame update
    void Start()
    {
        _falseCount = GetComponentInParent<FalseCount>();
    }
    private void OnDisable()
    {
        _falseCount.ExitCounter += 1;
    }
}
