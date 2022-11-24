using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>Tamura�̃X�e�[�W�̃v���C���[�̓���</summary>
public class TamuraStagePlayer : MonoBehaviour
{
    [Tooltip("�C���v�b�g���󂯎��")] private PlayerInput _playerInput;
    [Tooltip("�v���C���[�̃��W�b�g�{�f�B")] private Rigidbody2D _playerRb;

    void Start()
    {
        _playerInput = gameObject.GetComponent<PlayerInput>();
        _playerRb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _playerRb.velocity = _playerInput.MoveInput *10;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        if(collision.gameObject.name == "PlayerOutLine")
        {
            //�X�e�[�W���s...
            GameManager.StageEnd(false);
        }

    }
}
