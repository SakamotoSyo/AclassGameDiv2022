using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>Tamuraのステージのプレイヤーの動き</summary>
public class TamuraStagePlayer : MonoBehaviour
{
    [Tooltip("インプットを受け取る")] private PlayerInput _playerInput;
    [Tooltip("プレイヤーのリジットボディ")] private Rigidbody2D _playerRb;
    [Tooltip("死んだ判定")] private bool _isDead = false;

    void Start()
    {
        _playerInput = gameObject.GetComponent<PlayerInput>();
        _playerRb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //_playerRb.velocity = _playerInput.MoveInput *10;

        //動いてて死んでなかったら死ぬ
        if((Input.GetAxisRaw($"Horizontal") != 0 || Input.GetAxisRaw($"Vertical") != 0) && !_isDead)
        {
            _isDead = true;
            //ステージ失敗...
            GameManager.StageEnd(false);
        }

    }

    /*private void OnTriggerExit2D(Collider2D collision)
    {

        if(collision.gameObject.name == "PlayerOutLine" && !_isDead)
        {
            _isDead = true;
            //ステージ失敗...
            GameManager.StageEnd(false);
        }

    }*/
}
