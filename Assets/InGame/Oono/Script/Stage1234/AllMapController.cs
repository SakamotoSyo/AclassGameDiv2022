using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllMapController : MonoBehaviour
{
    /// <summary>Inputシステム</summary>
    private PlayerInput _playerInput;
    private Rigidbody2D _rd2d;
    /// <summary>Playerの移動速度</summary>
    [SerializeField, Header("PlayerSpeed")] private int _playerSpeed = 5;

    GameObject onoff;
    OnOffController onOffController;

    GameObject player;
    PlayerHitPoint playerHitPoint;

    float _time;


    private void Start()
    {
        _playerInput = GetComponent<PlayerInput>();
        _rd2d = GetComponent<Rigidbody2D>();

        onoff = GameObject.Find("OnOffController");
        onOffController = onoff.GetComponent<OnOffController>();

        player = GameObject.Find("Player");
        playerHitPoint = player.GetComponent<PlayerHitPoint>();

        _time = 0;
    }

    private void Update()
    {
        _time = _time + Time.deltaTime;

        if(_time >= 3.0f)
        {
            PlyerMove();

            if (onOffController._p >= 1)
            {
                PlyerStop();
                _time = 0;
            }
        }

        if(playerHitPoint._fcount >= 1)
        {
            PlyerStop();
            _time = 0;
        }
    }

    void PlyerMove()
    {
        _rd2d.velocity = _playerInput.MoveInput.normalized * _playerSpeed;
    }

    void PlyerStop()
    {
        _rd2d.velocity = _playerInput.MoveInput.normalized * 0;
    }

    public void AddDamage()
    {
        GameManager.StageEnd(false);
    }
}
