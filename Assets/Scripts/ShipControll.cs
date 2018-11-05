using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//using UnityEngine.ParticleSystem;

public class ShipControll : MonoBehaviour {

    public Text txt;
    private Rigidbody rb;
    public float speed;

	void Start ()
    {
        Cursor.visible = false;
        rb = GetComponent<Rigidbody>();
	}

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(transform.forward * -speed);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            rb.AddRelativeTorque(0f, 0f, 1000f);
        }
        if (Input.GetKey(KeyCode.E))
        {
            rb.AddRelativeTorque(0f, 0f, -1000f);
        }
        txt.text = "" + Mathf.FloorToInt(rb.velocity.magnitude * 10);
        rb.AddRelativeTorque(-Input.GetAxis("Mouse Y") * 1000, Input.GetAxis("Mouse X") * 1000, 0f);
    }

    void OnTriggerEnter(Collider bon)
    {
        if (bon.gameObject.tag == "Bonus")
        {
            speed += 500;
            Destroy(bon.gameObject);
        }
        if (bon.gameObject.tag == "Bonus2")
        {
            rb.angularDrag += 0.2f;
            Destroy(bon.gameObject);
        }
    } 

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape)) SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        //transform.Rotate(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0f);
        //rb.AddRelativeTorque(-Input.GetAxis("Mouse Y") * 1000, Input.GetAxis("Mouse X") * 1000, 0f);
    }
}
