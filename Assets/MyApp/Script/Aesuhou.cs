using System.Collections;
using System.Collections.Generic;
using UnityEngine;


enum status
{
    Floor,
    Wall,
    Start,
    Goal,
    Open,
    Close,
}
public class Aesuhou : MonoBehaviour
{

    private int _estimateCost;  //����R�X�g
    private int _acutualCost;�@�@// ���R�X�g
    private int _totalCost;�@�@�@//�g�[�^���R�X�g
    private Vector3 _currentlocation;�@�@// ���݂̈ʒu
    private Vector3 _lastlocation;  �@�@// �O�̈ʒu
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
