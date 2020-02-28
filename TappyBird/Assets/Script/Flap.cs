using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(Rigidbody2D))]
public class Flap : MonoBehaviour
{   
    public float tapForce = 10f;
    public float tiltForce = 5f;
    public Vector3 startPos;


    public Rigidbody2D rb;
    Quaternion downRotation;
    Quaternion forwardRotation;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        downRotation = Quaternion.Euler(0,0,90);
        forwardRotation = Quaternion.Euler(0,0,35);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       if(Input.GetKeyDown("space"))
       {
           transform.rotation = forwardRotation;
           rb.velocity = Vector2.zero;
           rb.AddForce(Vector2.up * tapForce,ForceMode2D.Force);
       } 
       transform.rotation = Quaternion.Lerp(transform.rotation, downRotation, tiltForce*Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Deadzone")
        {
            EndGame();
        }
    }
    void EndGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
