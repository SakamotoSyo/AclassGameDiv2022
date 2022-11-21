using UnityEngine;

/// <summary>�X�^�[�g�O�̎��ɁA�c�胉�C�t�����o����</summary>
public class LifeMarkSpawn : MonoBehaviour
{
    [Tooltip("���C�t�̍ő吔")] private int _maxLife = 2;
    [SerializeField, Range(0, 2), Tooltip("����������")] private�@int _lifeCount;
    [SerializeField, Header("���C�t")] private GameObject _life = default;
    [SerializeField, Header("���������C�t")] private GameObject _loseLife = default;
    [SerializeField, Header("���C�t���o���ꏊ�̔z��")] private GameObject[] _lifeSpawner = new GameObject[2];

    void Start()
    {
        //���C�t���Q�[���}�l�[�W���[�������Ă���
        _lifeCount = GameManager.GetLife;
        
        for(int i = 0; i < _maxLife; i++)
        {

            if(i < _lifeCount)
            {
                //���̃��C�t�̐������A���C�t�̃I�u�W�F�N�g�𐶐�
                Instantiate(_life, _lifeSpawner[i].transform);
            }
            else
            {
                //���������C�t�̐������A�������C�t�̃I�u�W�F�N�g�𐶐�
                Instantiate(_loseLife, _lifeSpawner[i].transform);
            }

        }

    }
}
