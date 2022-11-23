using UnityEngine;

/// <summary>Floweyの弾の挙動</summary>
public class TamuraFloweyBulletController : MonoBehaviour
{
    [SerializeField, Header("親オブジェクト(Flowey)")] private TamuraFloweyController _flowey;
    [Tooltip("もともとの位置")] private Vector2 _originPos;

    private void Start()
    {
        //_originPos = gameObject.GetComponent<Transform>().position;
    }

    private void OnDisable()
    {
        //元の位置に戻す
        //transform.position = _originPos;
    }

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
            _flowey.ChildrenCheck();
        }

    }

}
