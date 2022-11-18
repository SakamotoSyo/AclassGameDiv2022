using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>スタート前の時に、残りライフを何個出すか</summary>
public class LifeMarkSpawn : MonoBehaviour
{
    [SerializeField, Tooltip("いくつだすか")] private　int _lifeSpawn;
    [SerializeField, Header("出したいオブジェクト")] private GameObject[] _life = new GameObject[2];

    void Start()
    {
        //ライフをゲームマネージャーから取ってくる
        //_lifeSpawn = 
        
        for(int i = 0; i < _lifeSpawn; i++)
        {
            //今のライフの数だけ、ライフのオブジェクトを生成
            Instantiate(_life[i], gameObject.transform);
        }

    }
}
