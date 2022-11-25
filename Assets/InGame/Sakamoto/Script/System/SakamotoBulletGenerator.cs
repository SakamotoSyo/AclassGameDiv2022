using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SakamotoBulletGenerator : MonoBehaviour
{
    SpawnData[] _spawnDataAll => _spawnData;
    [SerializeField] SpawnData[] _spawnData;
    [Header("弾幕を発射し終わってからどのくらいの時間でゴールにするか")]
    [SerializeField] float _goalWait;

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
                yield return new WaitForSeconds(_spawnDataAll[i].GetCoolTime);
            }
        }

        yield return new WaitForSeconds(_goalWait);
        SceneManagerController.AllStageClearScene();
    }

    private void ChooseEffect() 
    {

    }
}

[System.Serializable]
public class SpawnData
{
    /// <summary>弾幕のCoolTime</summary>
    [SerializeField, Header("弾幕のCoolTime")] private float _coolTime = 3;
    public float GetCoolTime => _coolTime;
    /// <summary>弾幕のスポーン地点</summary>
    [SerializeField, Header("弾幕のスポーン地点")] Transform _sponPosition;
    public Transform GetSponPosition => _sponPosition;
    /// <summary>使用したい弾幕</summary>
    [SerializeField, Header("使用したい弾幕を選択")] PoolObjectType _bulletType;
    public int BulletCount => _bulletCount;
    [SerializeField, Header("弾幕を連続で使う回数")] int _bulletCount;

    public float RotateNum => _rotateNum;
    [SerializeField, Header("回転させる角度")] float _rotateNum;
    public PoolObjectType GetBulletType => _bulletType;

}
