using UnityEngine;

/// <summary>Flowey�̒e�̋���</summary>
public class TamuraFloweyBulletController : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //PlayerOutLine�ɂ���������t�����֖߂��Ă���
        if(collision.CompareTag("PlayerOutLine"))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = -gameObject.GetComponent<Rigidbody2D>().velocity;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //�O�֏o����e�I�u�W�F�N�g�ɓ`����
        if(collision.gameObject.name == "Generator")
        {
            GetComponentInParent<TamuraFloweyController>().ChildrenCheck();
        }

    }

}
