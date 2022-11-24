using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReLoadScene : MonoBehaviour
{
    float _time;

    [SceneName]
    [SerializeField] string _sceneName;

    GameObject player;
    PlayerHitPoint playerHitPoint;

    // Start is called before the first frame update
    void Start()
    {
        _time = 0;

        player = GameObject.Find("Player");
        playerHitPoint = player.GetComponent<PlayerHitPoint>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (playerHitPoint._count >= 3)
        {
            _time = _time + Time.deltaTime;

            if(_time >= 1.0f)
            {
                _time = 0;

                SceneManagerController.LoadScene(_sceneName);
            }
        }
    }
}
