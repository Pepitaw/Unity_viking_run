using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LandSpawner : MonoBehaviour
{
    Vector3 pos;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "viking")
        {
            if (transform.name == "landscape1")
            {
                pos = GameObject.Find("landscape3").transform.localPosition;
                pos.x += 52;
                GameObject.Find("landscape4").transform.localPosition = pos;
                for (int i = 1; i < 4; i++)
                    GameObject.Find("landscape4/Coins/Viking_Shield" + i.ToString()).gameObject.SetActive(true);
            }
            else if (transform.name == "landscape2")
            {
                pos = GameObject.Find("landscape4").transform.localPosition;
                pos.z += 52;
                GameObject.Find("landscape5").transform.localPosition = pos;
            }
            else if (transform.name == "landscape3")
            {
                pos = GameObject.Find("landscape5").transform.localPosition;
                pos.x -= 52;
                GameObject.Find("landscape1").transform.localPosition = pos;
                for (int i = 1; i < 4; i++)
                    GameObject.Find("landscape1/Coins/Viking_Shield" + i.ToString()).gameObject.SetActive(true);
            }
            else if (transform.name == "landscape4")
            {
                pos = GameObject.Find("landscape1").transform.localPosition;
                pos.z += 52;
                GameObject.Find("landscape2").transform.localPosition = pos;
                for (int i = 1; i < 4; i++)
                    GameObject.Find("landscape2/Coins/Viking_Shield" + i.ToString()).gameObject.SetActive(true);
            }
            else if (transform.name == "landscape5")
            {
                pos = GameObject.Find("landscape2").transform.localPosition;
                pos.z += 52;
                GameObject.Find("landscape3").transform.localPosition = pos;
            }
        }
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
