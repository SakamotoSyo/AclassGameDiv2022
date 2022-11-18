using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// スタート前の時に、残りライフを何個出すか
/// </summary>
public class LifeMarkSpawn : MonoBehaviour
{
    [SerializeField, Tooltip("いくつだすか")] int _lifeSpawn;
    [SerializeField, Header("出したいオブジェクト")] GameObject _life;

    void Start()
    {
        //ライフをゲームマネージャーから取ってくる
        //_lifeSpawn = 
        
        for(int i = 0; i < _lifeSpawn; i++)
        {
            //今のライフの数だけ、ライフのオブジェクトを生成
            //生成する場所を変えるやりかたがわからね～～～～
            Instantiate(_life, gameObject.transform);
        }

    }
}
