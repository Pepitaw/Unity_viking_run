using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinColider : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "viking")
            gameObject.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
