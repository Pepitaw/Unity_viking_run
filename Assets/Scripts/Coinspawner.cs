using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coinspawner : MonoBehaviour
{
    // Start is called before the first frame update
    List<Transform> CoinList;
    public Transform coin;
    void Start()
    {
        CoinList = new List<Transform>();
        for (int i = 0; i < 5; i++)
        {
            Transform t = Instantiate(coin);
            Transform p = transform.GetChild((int)Random.Range(0, transform.childCount));
            t.parent = p;
            t.localPosition = p.localPosition;
            CoinList.Add(t);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
