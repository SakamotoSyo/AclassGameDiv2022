using UnityEngine;

/// <summary>スタート前の時に、残りライフを何個出すか</summary>
public class LifeMarkSpawn : MonoBehaviour
{
    [Tooltip("ライフの最大数")] private int _maxLife = 2;
    [SerializeField, Range(0, 2), Tooltip("いくつだすか")] private　int _lifeCount;
    [SerializeField, Header("ライフ")] private GameObject _life = default;
    [SerializeField, Header("失ったライフ")] private GameObject _loseLife = default;
    [SerializeField, Header("ライフを出す場所の配列")] private GameObject[] _lifeSpawner = new GameObject[2];

    void Start()
    {
        //ライフをゲームマネージャーから取ってくる
        _lifeCount = GameManager.GetLife;
        
        for(int i = 0; i < _maxLife; i++)
        {

            if(i < _lifeCount)
            {
                //今のライフの数だけ、ライフのオブジェクトを生成
                Instantiate(_life, _lifeSpawner[i].transform);
            }
            else
            {
                //失ったライフの数だけ、黒いライフのオブジェクトを生成
                Instantiate(_loseLife, _lifeSpawner[i].transform);
            }

        }

    }
}
