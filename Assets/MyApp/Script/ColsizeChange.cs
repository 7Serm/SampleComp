using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColsizeChange : MonoBehaviour
{

    private CapsuleCollider Col;  // カプセルコライダーのコンポーネントを入れるための変数

    [Tooltip("ここにはセンターアイアンカーをアタッチします")]
    [SerializeField] private float y;　// ここはセンターアイアンカーに入れ替わる変数　本来はGameObjectをアタッチして　transformのyの値を取得のために使う

    private Vector3 v3;　　//ベクター３型の変数　
    // Start is called before the first frame update
    void Start()
    {
        Col = GetComponent<CapsuleCollider>();　　//Colにカプセルコライダーコンポーネントを取得させている

    }

    // Update is called once per frame
    void Update()
    {
        v3 = new Vector3(0, y / 2, 0);　　// ｖ3に　ｘは0　ｙは高さの半分を　ｚは0　入れている
        Col.height = y;　　　　　　　　　　//高さにはセンターアイアンカーの位置を入れるようにする
        Col.center = v3; //transform.InverseTransformPoint(v3);  センターのｙに高さの半分位置に移動いるようにしている
    }
}
