using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SakamotoBulletGenerator : MonoBehaviour
{
    SpawnData[] _spawnDataAll => _spawnData;
    [SerializeField] SpawnData[] _spawnData;


    float saveRote;
    private void Start()
    {
        StartCoroutine(bulletGenelater());
    }
    private void Update()
    {

    }

    IEnumerator bulletGenelater()
    {
        for (int i = 0; i < _spawnDataAll.Length; i++)
        {
            for (int j = 0; j < _spawnDataAll[i].BulletCount; j++) 
            {
                var obj = ObjectPool.Instance.UseObject(_spawnDataAll[i].GetSponPosition.position, _spawnDataAll[i].GetBulletType);
               // saveRote += _spawnDataAll[i].RotateNum;
               // obj.transform.rotation = Quaternion.Euler(0.0f, 0.0f, saveRote);
                yield return new WaitForSeconds(_spawnDataAll[i].GetCoolTime);
            }
        }
    }

    private void ChooseEffect() 
    {

    }
}

[System.Serializable]
public class SpawnData
{
    /// <summary>�e����CoolTime</summary>
    [SerializeField, Header("�e����CoolTime")] private float _coolTime = 3;
    public float GetCoolTime => _coolTime;
    /// <summary>�e���̃X�|�[���n�_</summary>
    [SerializeField, Header("�e���̃X�|�[���n�_")] Transform _sponPosition;
    public Transform GetSponPosition => _sponPosition;
    /// <summary>�g�p�������e��</summary>
    [SerializeField, Header("�g�p�������e����I��")] PoolObjectType _bulletType;
    public int BulletCount => _bulletCount;
    [SerializeField, Header("�e����A���Ŏg����")] int _bulletCount;

    public float RotateNum => _rotateNum;
    [SerializeField, Header("��]������p�x")] float _rotateNum;
    public PoolObjectType GetBulletType => _bulletType;

}