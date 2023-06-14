using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class CreatePbj : MonoBehaviour
{

  //  [SerializeField] private Transform[] CreatePoint;
  //  [SerializeField] private GameObject[] Gameobj;
    [SerializeField] private List<GameObject> GameObjects; // MAP生成に必要なオブジェクトを入れるためのリスト

    [SerializeField] private List<Transform> CreateP;　　//生成位置の場所を示す位置座標を持ったからオブジェクト

    private int Randnum;　　// 位置オブジェクトをランダムに選択するための変数
    private int Lcount;　　// リストの要素数を入れるための変数
    // Start is called before the first frame update
    void Start()
    {
        Lcount = CreateP.Count;　　//リストの要素数の取得
        int l = Lcount;　　　　　// for文のループ回数決めるための変数
        for(int i = 0; i <  l; i++)
        {
           Randnum =  Random.Range(0, Lcount);　　//ランダムな値の取得
            Instantiate(GameObjects[i], CreateP[Randnum]);　　// MAPリストにあるオブジェクトを順番に　ランダムな位置に生成
           // GameObjects.RemoveAt(i);
            CreateP.RemoveAt(Randnum);　　// 生成位置が被らないようにリストから削除
            Lcount = CreateP.Count;　　　// 削除後のリストの要素数の取得
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
