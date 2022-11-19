using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerInput : MonoBehaviour
{
    [Header("�������g�̃v���C���[�ԍ�")]
    [SerializeField] private int _playerNum;

    [Tooltip("��������")]
    private Vector2 _movement;
    [Tooltip("����Action����")]
    private bool _isAction = false;
    [Tooltip("Input���u���b�N���邩�ǂ���")]
    private bool _inputBlock = false;

    /// <summary>���݃A�N�V���������ǂ����Ԃ�</summary>
    public bool Action
    {
        get { return _isAction && !_inputBlock; }
    }
    /// <summary>���݂̕������͂�Ԃ�</summary>
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


    /// <summary>Input�Ɋւ�����͂��󂯕t���邩�ǂ����ύX����</summary>
    public void InputBlock()
    {
        _inputBlock = !_inputBlock;
    }
}
