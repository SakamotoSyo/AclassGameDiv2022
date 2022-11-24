using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHeartController : MonoBehaviour
{
    /// <summary>Input�V�X�e��</summary>
    private PlayerInput _playerInput;
    private Rigidbody2D _rd2d;
    /// <summary>Player�̈ړ����x</summary>
    [SerializeField, Header("PlayerSpeed")] private int _playerSpeed = 5;


    private void Start()
    {
        _playerInput = GetComponent<PlayerInput>();
        _rd2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        PlyerMove();
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
