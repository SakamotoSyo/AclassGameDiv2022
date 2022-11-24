using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>Tamuraのステージのプレイヤーの動き</summary>
public class TamuraStagePlayer : MonoBehaviour
{
    [Tooltip("インプットを受け取る")] private PlayerInput _playerInput;
    [Tooltip("プレイヤーのリジットボディ")] private Rigidbody2D _playerRb;

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
            //ステージ失敗...
            GameManager.StageEnd(false);
        }

    }
}
