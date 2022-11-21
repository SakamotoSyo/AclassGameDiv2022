using UnityEngine;

/// <summary>スタート前の時に、残りライフを何個出すか</summary>
public class LifeMarkSpawn : MonoBehaviour
{
    [SerializeField, Range(0, 2), Tooltip("いくつだすか")] private　int _lifeCount;
    [SerializeField, Header("出したいオブジェクト")] private GameObject _life = default;
    [SerializeField, Header("ライフを出す場所の配列")] private GameObject[] _lifeSpawner = new GameObject[2];

    void Start()
    {
        //ライフをゲームマネージャーから取ってくる
        _lifeCount = GameManager.GetLife;
        
        for(int i = 0; i < _lifeCount; i++)
        {
            //今のライフの数だけ、ライフのオブジェクトを生成
            Instantiate(_life, _lifeSpawner[i].transform);
        }

        //失ったライフも表示させたい
    }
}
