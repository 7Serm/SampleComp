using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class CreatePbj : MonoBehaviour
{

  //  [SerializeField] private Transform[] CreatePoint;
  //  [SerializeField] private GameObject[] Gameobj;
    [SerializeField] private List<GameObject> GameObjects; // MAP�����ɕK�v�ȃI�u�W�F�N�g�����邽�߂̃��X�g

    [SerializeField] private List<Transform> CreateP;�@�@//�����ʒu�̏ꏊ�������ʒu���W������������I�u�W�F�N�g

    private int Randnum;�@�@// �ʒu�I�u�W�F�N�g�������_���ɑI�����邽�߂̕ϐ�
    private int Lcount;�@�@// ���X�g�̗v�f�������邽�߂̕ϐ�
    // Start is called before the first frame update
    void Start()
    {
        Lcount = CreateP.Count;�@�@//���X�g�̗v�f���̎擾
        int l = Lcount;�@�@�@�@�@// for���̃��[�v�񐔌��߂邽�߂̕ϐ�
        for(int i = 0; i <  l; i++)
        {
           Randnum =  Random.Range(0, Lcount);�@�@//�����_���Ȓl�̎擾
            Instantiate(GameObjects[i], CreateP[Randnum]);�@�@// MAP���X�g�ɂ���I�u�W�F�N�g�����ԂɁ@�����_���Ȉʒu�ɐ���
           // GameObjects.RemoveAt(i);
            CreateP.RemoveAt(Randnum);�@�@// �����ʒu�����Ȃ��悤�Ƀ��X�g����폜
            Lcount = CreateP.Count;�@�@�@// �폜��̃��X�g�̗v�f���̎擾
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
