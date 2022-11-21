using UnityEngine;

/// <summary>�X�^�[�g�O�̎��ɁA�c�胉�C�t�����o����</summary>
public class LifeMarkSpawn : MonoBehaviour
{
    [SerializeField, Range(0, 2), Tooltip("����������")] private�@int _lifeCount;
    [SerializeField, Header("�o�������I�u�W�F�N�g")] private GameObject _life = default;
    [SerializeField, Header("���C�t���o���ꏊ�̔z��")] private GameObject[] _lifeSpawner = new GameObject[2];

    void Start()
    {
        //���C�t���Q�[���}�l�[�W���[�������Ă���
        _lifeCount = GameManager.GetLife;
        
        for(int i = 0; i < _lifeCount; i++)
        {
            //���̃��C�t�̐������A���C�t�̃I�u�W�F�N�g�𐶐�
            Instantiate(_life, _lifeSpawner[i].transform);
        }

        //���������C�t���\����������
    }
}
