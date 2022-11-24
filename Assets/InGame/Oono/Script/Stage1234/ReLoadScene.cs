using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReLoadScene : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem particle;

    float _time;

    [SceneName]
    [SerializeField] string _sceneName;

    GameObject player;
    PlayerHitPoint playerHitPoint;

    int _i;

    // Start is called before the first frame update
    void Start()
    {
        _time = 0;

        player = GameObject.Find("Player");
        playerHitPoint = player.GetComponent<PlayerHitPoint>();

        _i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        

        if (playerHitPoint._gameOver)
        {
            _time = _time + Time.deltaTime;

            Effect();

            if(_time >= 3.0f)
            {
                _time = 0;

                SceneManagerController.LoadScene(_sceneName);
            }
        }
    }

    void Effect()
    {
        ParticleSystem newParticle = Instantiate(particle);
        for (int i = 0; i < 1; i++)
        {
            newParticle.Play();
        }
    }
}
