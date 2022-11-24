using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOffController : MonoBehaviour
{
    GameObject _light;
    LightsController lightsController;

    GameObject backG;
    BackGroundController backGroundController;

    GameObject player;
    PlayerHitPoint playerHitPoint;

    public int _p;
    public bool _gameo;
    int _i;

    // Start is called before the first frame update
    void Start()
    {
        _light = GameObject.Find("Lights");
        lightsController = _light.GetComponent<LightsController>();

        backG = GameObject.Find("BackGround");
        backGroundController = backG.GetComponent<BackGroundController>();

        player = GameObject.Find("Player");
        playerHitPoint = player.GetComponent<PlayerHitPoint>();

        _p = 0;
        _gameo = false;
        _i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(playerHitPoint._gameOver)
        {
            Lbg();
            _gameo = true;
        }
        else
        {
            if (_i == 0)
            {
                Invoke("Lon", 3.0f);
                _i = _i + 1;
            }

            if (_p >= 1)
            {
                Loff();
                _p = 0;
            }
        }
    }

    void Lon()
    {
        lightsController.Up();
    }

    void Loff()
    {
        lightsController.Down();
        Invoke("Lon", 3.0f);
    }

    void Lbg()
    {
        backGroundController.Up();
    }
}
