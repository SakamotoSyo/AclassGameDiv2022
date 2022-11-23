using UnityEngine;

/// <summary>Floweyの弾の挙動</summary>
public class TamuraFloweyBulletController : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //PlayerOutLineにあたったら逆方向へ戻っていく
        if(collision.CompareTag("PlayerOutLine"))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = -gameObject.GetComponent<Rigidbody2D>().velocity;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //外へ出たら親オブジェクトに伝える
        if(collision.gameObject.name == "Generator")
        {
            GetComponentInParent<TamuraFloweyController>().ChildrenCheck();
        }

    }

}
