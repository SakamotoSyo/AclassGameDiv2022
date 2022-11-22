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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out IDamage _damage))
        {
            _damage.AddDamage();
        }
    }
    public void BulletsCount()
    {
        _falseCount.ExitCounter += 1;
    }
}
