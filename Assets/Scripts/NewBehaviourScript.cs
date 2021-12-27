using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public float movingspeed = 10f;
    public float JumpingForces = 50000f;
    public int distance = 200;
    Rigidbody rb;
    Animator animator;
    Animator petanimator;
    NavMeshAgent agent;
    bool bump = false;
    bool isjump = true;
    bool run = false;
    bool catchup = false;
    int ti;
    int coin = 0;
    public GameObject petObject;
    public List<Vector3> positionList;

    void Awake()
    {
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        petanimator = petObject.GetComponent<Animator>();
        ti = (int)Time.time;
    }

    void OnCollisionEnter(Collision collision)
    {
        isjump = true;
        if (collision.transform.name == "Viking_Shield1" || collision.transform.name == "Viking_Shield2" || collision.transform.name == "Viking_Shield3")
            coin++;

        if (collision.transform.name == "Viking_Sword")
        {
            bump = true;
            catchup = true;
            GameObject.Find("Canvas/TimeText").gameObject.GetComponent<Text>().text = "Time " + ((int)Time.time - ti).ToString();
            GameObject.Find("Canvas/DeadText").gameObject.GetComponent<Text>().enabled = true;
            isjump = false;
            GameObject.Find("Viking_Sword").gameObject.GetComponent<AudioSource>().mute = true;
            GameObject.Find("viking/alpha").gameObject.GetComponent<AudioSource>().mute = false;
        }

    }
    // Update is called once per frame
    void Update()
    {
        run = false;
        gameObject.GetComponent<AudioSource>().mute = true;
        Vector3 Rot = gameObject.transform.localRotation.eulerAngles;

        if (!bump)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                Rot = gameObject.transform.localRotation.eulerAngles;
                Rot.y = (int)Rot.y - 90;
                transform.localRotation = Quaternion.Euler(Rot);
                if (Rot.y % 360 == 180)
                    Rot.y = 0;
                petObject.transform.localRotation = Quaternion.Euler(Rot);
                run = true;
                gameObject.GetComponent<AudioSource>().mute = false;
            }

            else if (Input.GetKeyDown(KeyCode.E))
            {
                Rot = gameObject.transform.localRotation.eulerAngles;
                Rot.y = (int)Rot.y + 90;
                transform.localRotation = Quaternion.Euler(Rot);
                if (Rot.y % 360 == 180)
                    Rot.y = 0;
                petObject.transform.localRotation = Quaternion.Euler(Rot);
                run = true;
                gameObject.GetComponent<AudioSource>().mute = false;
            }
            float k = Rot.y % 360;
            if (k == 90)
            {
                if (Input.GetKey(KeyCode.W))
                {
                    transform.localPosition += Vector3.right * movingspeed * Time.deltaTime;
                    run = true;
                    gameObject.GetComponent<AudioSource>().mute = false;
                }

                if (Input.GetKey(KeyCode.S))
                {
                    transform.localPosition += Vector3.left * movingspeed * Time.deltaTime;
                    run = true;
                    gameObject.GetComponent<AudioSource>().mute = false;
                }

                if (Input.GetKey(KeyCode.A))
                {
                    transform.localPosition += Vector3.forward * movingspeed * Time.deltaTime;
                    run = true;
                    gameObject.GetComponent<AudioSource>().mute = false;
                }

                if (Input.GetKey(KeyCode.D))
                {
                    transform.localPosition += Vector3.back * movingspeed * Time.deltaTime;
                    run = true;
                    gameObject.GetComponent<AudioSource>().mute = false;
                }
            }
            else if (k == -90 || k == 270)
            {
                if (Input.GetKey(KeyCode.W))
                {
                    transform.localPosition += Vector3.left * movingspeed * Time.deltaTime;
                    run = true;
                    gameObject.GetComponent<AudioSource>().mute = false;
                }

                if (Input.GetKey(KeyCode.S))
                {
                    transform.localPosition += Vector3.right * movingspeed * Time.deltaTime;
                    run = true;
                    gameObject.GetComponent<AudioSource>().mute = false;
                }

                if (Input.GetKey(KeyCode.A))
                {
                    transform.localPosition += Vector3.back * movingspeed * Time.deltaTime;
                    run = true;
                    gameObject.GetComponent<AudioSource>().mute = false;
                }

                if (Input.GetKey(KeyCode.D))
                {
                    transform.localPosition += Vector3.forward * movingspeed * Time.deltaTime;
                    run = true;
                    gameObject.GetComponent<AudioSource>().mute = false;
                }
            }
            else if (k == 180)
            {
                if (Input.GetKey(KeyCode.W))
                {
                    transform.localPosition += Vector3.back * movingspeed * Time.deltaTime;
                    run = true;
                    gameObject.GetComponent<AudioSource>().mute = false;
                }

                if (Input.GetKey(KeyCode.S))
                {
                    transform.localPosition += Vector3.forward * movingspeed * Time.deltaTime;
                    run = true;
                    gameObject.GetComponent<AudioSource>().mute = false;
                }

                if (Input.GetKey(KeyCode.A))
                {
                    transform.localPosition += Vector3.right * movingspeed * Time.deltaTime;
                    run = true;
                    gameObject.GetComponent<AudioSource>().mute = false;
                }

                if (Input.GetKey(KeyCode.D))
                {
                    transform.localPosition += Vector3.left * movingspeed * Time.deltaTime;
                    run = true;
                    gameObject.GetComponent<AudioSource>().mute = false;
                }
            }
            else
            {

                if (Input.GetKey(KeyCode.W))
                {
                    transform.localPosition += Vector3.forward * movingspeed * Time.deltaTime;
                    run = true;
                    gameObject.GetComponent<AudioSource>().mute = false;
                }

                if (Input.GetKey(KeyCode.S))
                {
                    transform.localPosition += Vector3.back * movingspeed * Time.deltaTime;
                    run = true;
                    gameObject.GetComponent<AudioSource>().mute = false;
                }

                if (Input.GetKey(KeyCode.A))
                {
                    transform.localPosition += Vector3.left * movingspeed * Time.deltaTime;
                    run = true;
                    gameObject.GetComponent<AudioSource>().mute = false;
                }

                if (Input.GetKey(KeyCode.D))
                {
                    transform.localPosition += Vector3.right * movingspeed * Time.deltaTime;
                    run = true;
                    gameObject.GetComponent<AudioSource>().mute = false;
                }
            }
            if (isjump && Input.GetKey(KeyCode.Space))
            {
                rb.AddForce(0, JumpingForces * Time.deltaTime, 0);
                isjump = false;
            }
            positionList.Add(transform.localPosition);
            GameObject.Find("Canvas/TimeText").gameObject.GetComponent<Text>().text = "Time " + ((int)Time.time - ti).ToString();
            GameObject.Find("Canvas/CoinText").gameObject.GetComponent<Text>().text = "Coin " + coin.ToString();

        }

        animator.SetBool("run", run);
        petanimator.SetBool("catch", catchup);


        if (positionList.Count > distance)
        {
            positionList.RemoveAt(0);
            petObject.transform.localPosition = positionList[0];
        }
    }
}
