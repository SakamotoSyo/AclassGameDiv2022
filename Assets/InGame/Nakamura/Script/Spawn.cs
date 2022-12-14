using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    SponData[] _sponDataAll => _sponData;
    [SerializeField] SponData[] _sponData;
    
    private void Start()
    {
        StartCoroutine(bulletGenelater());
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<Shot>(out Shot shot))
        {
            shot.BulletsCount();
        }
        else if (collision.gameObject.TryGetComponent<BulletControlle>(out BulletControlle bullet))
        {
            bullet.BulletsCount();
        }
    }

    IEnumerator bulletGenelater()
    {
        for (int i = 0; i < _sponDataAll.Length; i++)
        {
            ObjectPool.Instance.UseObject(_sponDataAll[i].GetSponPosition.position, _sponDataAll[i].GetBulletType);
            yield return new WaitForSeconds(_sponDataAll[i].GetCoolTime);
        }
    }
}

[System.Serializable]
public class SponData 
{
    /// <summary>eΜCoolTime</summary>
    [SerializeField, Header("eΜCoolTime")] private float _coolTime = 3;
    public float GetCoolTime => _coolTime;
    /// <summary>eΜX|[n_</summary>
    [SerializeField, Header("eΜX|[n_")] Transform _sponPosition;
    public Transform GetSponPosition => _sponPosition;
    /// <summary>gp΅½’e</summary>
    [SerializeField,Header("gp΅½’eπIπ")] PoolObjectType _bulletType;
    public PoolObjectType GetBulletType => _bulletType;
}

