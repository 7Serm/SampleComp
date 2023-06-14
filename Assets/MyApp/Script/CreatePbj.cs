using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class CreatePbj : MonoBehaviour
{

  //  [SerializeField] private Transform[] CreatePoint;
  //  [SerializeField] private GameObject[] Gameobj;
    [SerializeField] private List<GameObject> GameObjects;
    [SerializeField] private List<Transform> CreateP;

    private int Randnum;
    private int Lcount;
    // Start is called before the first frame update
    void Start()
    {
        Lcount = CreateP.Count;
        int l = Lcount;
        for(int i = 0; i <  l; i++)
        {
           Randnum =  Random.Range(0, Lcount);
            Instantiate(GameObjects[i], CreateP[Randnum]);
           // GameObjects.RemoveAt(i);
            CreateP.RemoveAt(Randnum);
            Lcount = CreateP.Count;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
