using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>�X�^�[�g�O�̎��ɁA�c�胉�C�t�����o����</summary>
public class LifeMarkSpawn : MonoBehaviour
{
    [SerializeField, Tooltip("����������")] private�@int _lifeSpawn;
    [SerializeField, Header("�o�������I�u�W�F�N�g")] private GameObject[] _life = new GameObject[2];

    void Start()
    {
        //���C�t���Q�[���}�l�[�W���[�������Ă���
        //_lifeSpawn = 
        
        for(int i = 0; i < _lifeSpawn; i++)
        {
            //���̃��C�t�̐������A���C�t�̃I�u�W�F�N�g�𐶐�
            Instantiate(_life[i], gameObject.transform);
        }

    }
}
