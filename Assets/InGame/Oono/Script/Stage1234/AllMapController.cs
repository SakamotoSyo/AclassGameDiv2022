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

    float _time;


    private void Start()
    {
        _playerInput = GetComponent<PlayerInput>();
        _rd2d = GetComponent<Rigidbody2D>();

        onoff = GameObject.Find("OnOffController");
        onOffController = onoff.GetComponent<OnOffController>();
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
                _rd2d.velocity = _playerInput.MoveInput.normalized * 0;
                _time = 0;
            }
        }
    }

    void PlyerMove()
    {
        _rd2d.velocity = _playerInput.MoveInput.normalized * _playerSpeed;
    }

    public void AddDamage()
    {
        GameManager.StageEnd(false);
    }
}
