using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColsizeChange : MonoBehaviour
{

    private CapsuleCollider Col;  // �J�v�Z���R���C�_�[�̃R���|�[�l���g�����邽�߂̕ϐ�

    [Tooltip("�����ɂ̓Z���^�[�A�C�A���J�[���A�^�b�`���܂�")]
    [SerializeField] private float y;�@// �����̓Z���^�[�A�C�A���J�[�ɓ���ւ��ϐ��@�{����GameObject���A�^�b�`���ā@transform��y�̒l���擾�̂��߂Ɏg��

    private Vector3 v3;�@�@//�x�N�^�[�R�^�̕ϐ��@
    // Start is called before the first frame update
    void Start()
    {
        Col = GetComponent<CapsuleCollider>();�@�@//Col�ɃJ�v�Z���R���C�_�[�R���|�[�l���g���擾�����Ă���

    }

    // Update is called once per frame
    void Update()
    {
        v3 = new Vector3(0, y / 2, 0);�@�@// ��3�Ɂ@����0�@���͍����̔������@����0�@����Ă���
        Col.height = y;�@�@�@�@�@�@�@�@�@�@//�����ɂ̓Z���^�[�A�C�A���J�[�̈ʒu������悤�ɂ���
        Col.center = v3; //transform.InverseTransformPoint(v3);  �Z���^�[�̂��ɍ����̔����ʒu�Ɉړ�����悤�ɂ��Ă���
    }
}
