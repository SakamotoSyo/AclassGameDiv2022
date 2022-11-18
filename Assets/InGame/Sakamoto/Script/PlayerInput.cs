using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerInput : MonoBehaviour
{
    [Header("自分自身のプレイヤー番号")]
    [SerializeField] private int _playerNum;

    [Tooltip("動く方向")]
    private Vector2 _movement;
    [Tooltip("現在Action中か")]
    private bool _isAction = false;
    [Tooltip("Inputをブロックするかどうか")]
    private bool _inputBlock = false;

    /// <summary>現在アクション中かどうか返す</summary>
    public bool Action
    {
        get { return _isAction && !_inputBlock; }
    }
    /// <summary>現在の方向入力を返す</summary>
    public Vector2 MoveInput
    {
        get
        {
            if (_inputBlock)
            {
                return Vector2.zero;
            }
            return _movement;
        }
    }
    private void Start()
    {
       // GameManager.GameStart += InputBlock;
    }

    private void Update()
    {
        _movement = new Vector2(Input.GetAxisRaw($"Horizontal"), Input.GetAxisRaw($"Vertical"));

        if (Input.GetButtonDown($"Fire1"))
        {
            _isAction = true;
        }
        else
        {
            _isAction = false;
        }
    }


    /// <summary>Inputに関する入力を受け付けるかどうか変更する</summary>
    public void InputBlock()
    {
        _inputBlock = !_inputBlock;
    }
}
