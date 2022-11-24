using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>DefauluStageのプレイヤー　弾に当たったらステージ失敗</summary>
public class DefaultStagePlayer : MonoBehaviour
{
    [Tooltip("インプットを受け取る")] private PlayerInput _playerInput;
    [Tooltip("プレイヤーのリジットボディ")] private Rigidbody2D _playerRb;
    [SerializeField, Header("プレイヤーの速さ")] private float _speed = 5;

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
            //当たったらステージ失敗
            GameManager.StageEnd(false);
        }
    }

}
