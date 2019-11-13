using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

	public Rigidbody rb;
	public float forwardForce = 500f;
	public float sidewaysForce = 500f;

    public bool controls = true;

    void FixedUpdate()
    {
        rb.AddForce(0,0, forwardForce * Time.deltaTime);

        if (controls == true)
        {
            if ((Input.GetKey(KeyCode.RightArrow)) || (Input.GetKey("d")))
            {
                rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
            }
            else if ((Input.GetKey(KeyCode.LeftArrow)) || (Input.GetKey("a")))
            {
                rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
            }
        } 
        
        if (rb.position.y < -10f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }


}
