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
        collision.gameObject.SetActive(false);
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
    /// <summary>�e����CoolTime</summary>
    [SerializeField, Header("�e����CoolTime")] private float _coolTime = 3;
    public float GetCoolTime => _coolTime;
    /// <summary>�e���̃X�|�[���n�_</summary>
    [SerializeField, Header("�e���̃X�|�[���n�_")] Transform _sponPosition;
    public Transform GetSponPosition => _sponPosition;
    /// <summary>�g�p�������e��</summary>
    [SerializeField,Header("�g�p�������e����I��")] PoolObjectType _bulletType;
    public PoolObjectType GetBulletType => _bulletType;
}

