using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class move : MonoBehaviour
{

    public float speed;
    public float power;
    public static bool gameStart;
    private float timer=0;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gameStart == true )
        {   
            timer += Time.deltaTime;
            if (speed < score.n)
            {
                speed += 0.01f;
            }
            transform.position += Vector3.forward * Time.deltaTime * speed;
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                transform.GetComponent<Rigidbody>().velocity = Vector3.left * 20;
            }
            else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                transform.GetComponent<Rigidbody>().velocity = Vector3.right * 20;
            }
            if (Input.GetKeyDown(KeyCode.Space) && timer >= 0.4f)
            {
                GetComponent<Rigidbody>().AddForce(Vector3.up * power, ForceMode.Impulse);
                timer = 0;
            }

            
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "floor")
        {
            Destroy(collision.gameObject);
            score.life--;
        }
    }
   
}



public class cameraMove : MonoBehaviour
{

    public float speed;
    public float power;
    public static bool gameStart;
    public Camera camera;
    void Start()
    {
    
    }
    void Update()
    {
        if (gameStart == true)
        {
            if (speed < 30)
            {
                speed += 0.01f;
            }
            transform.position += Vector3.forward * Time.deltaTime * speed;
        }
    }
}

