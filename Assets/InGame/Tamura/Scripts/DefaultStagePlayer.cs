using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>DefauluStage�̃v���C���[�@�e�ɓ���������X�e�[�W���s</summary>
public class DefaultStagePlayer : MonoBehaviour
{
    [Tooltip("�C���v�b�g���󂯎��")] private PlayerInput _playerInput;
    [Tooltip("�v���C���[�̃��W�b�g�{�f�B")] private Rigidbody2D _playerRb;
    [SerializeField, Header("�v���C���[�̑���")] private float _speed = 5;

    void Start()
    {
        _playerInput = gameObject.GetComponent<PlayerInput>();
        _playerRb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _playerRb.velocity = _playerInput.MoveInput * _speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Respawn")) 
        {
            //����������X�e�[�W���s
            GameManager.StageEnd(false);
        }
    }

}
