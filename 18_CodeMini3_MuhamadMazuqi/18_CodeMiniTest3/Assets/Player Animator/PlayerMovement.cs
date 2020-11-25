using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody PlayerRB;
    public Animator PlayerAnim;
    float speed = 10.0f;
    float vlimit = 5.0f;
    float moveSpeed = 10.0f;


    // Start is called before the first frame update
    void Start()
    {
        PlayerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            PlayerAnim.SetBool("iRun", true);
        }
        if (Input.GetKey(KeyCode.S))
        {

            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            transform.rotation = Quaternion.Euler(0, 180, 0);

        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            transform.rotation = Quaternion.Euler(0, -90, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            transform.rotation = Quaternion.Euler(0, 90, 0);
        }
        if (transform.position.x < -vlimit)
        {
            transform.position = new Vector3(-vlimit, transform.position.y, transform.position.z);

        }
        else if (transform.position.x > vlimit)
        {
            transform.position = new Vector3(vlimit, transform.position.y, transform.position.z);
        }
        if (transform.position.z < -vlimit)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -vlimit);
        }
        /*if (fTimerCount < 10 && isStartCount)
        {
            fTimerCount += Time.deltaTime;
            iCount = Mathf.RoundToInt(fTimerCount);
            textTimerCounterGO.GetComponent<Text>().text = "Timer CountUp " + iCount.ToString();
        }
        else if
        {
            fTimerCount = 0;
            iCount = 0;
            isStartCount = false;
            textTimerCounterGO.GetComponent<Text>().text = "Timer CountUp :" + iCount.Tostring();

            playPlaneBGO.GetComponent<Transform>().Rotate(0, 90, 0);
        }*/

    }
    void StartRun()
    {
        PlayerAnim.SetBool("iRun", true);
        PlayerAnim.SetFloat("Running State", 0.26f);
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cone"))
        {
            
        }
    }
}