using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadS : MonoBehaviour
{

    [SceneName]
    [SerializeField] string _sceneName;

    GameObject player;
    PlayerHitPoint playerHitPoint;
    bool _isClear = false;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playerHitPoint = player.GetComponent<PlayerHitPoint>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerHitPoint._gameClear && !_isClear)
        {
            Invoke("ChangeScene", 1.0f);
            _isClear = true;
        }
    }

    void ChangeScene()
    {
        GameManager.StageEnd(true);
    }
}
