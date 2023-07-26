using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jsontest : MonoBehaviour
{
    [SerializeField]
    private string json;

    [SerializeField]
    private 
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(json);

        Playerdata playerdata = JsonUtility.FromJson<Playerdata>(json);

        Debug.Log(playerdata.Player.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
