using UnityEngine;

/// <summary>Flowey�̒e�̋���</summary>
public class TamuraFloweyBulletController : MonoBehaviour
{
    [SerializeField, Header("�e�I�u�W�F�N�g(Flowey)")] private TamuraFloweyController _flowey;
    [Tooltip("���Ƃ��Ƃ̈ʒu")] private Vector2 _originPos;

    private void Start()
    {
        //_originPos = gameObject.GetComponent<Transform>().position;
    }

    private void OnDisable()
    {
        //���̈ʒu�ɖ߂�
        //transform.position = _originPos;
    }

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
            _flowey.ChildrenCheck();
        }

    }

}
