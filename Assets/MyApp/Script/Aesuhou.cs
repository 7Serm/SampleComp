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

    private int _estimateCost;  //推定コスト
    private int _acutualCost;　　// 実コスト
    private int _totalCost;　　　//トータルコスト
    private Vector3 _currentlocation;　　// 現在の位置
    private Vector3 _lastlocation;  　　// 前の位置
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
