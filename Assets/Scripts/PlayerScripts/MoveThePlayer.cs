using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveThePlayer : MonoBehaviour {
    public float speed, jump;
    float forceX, forceY;
    private Rigidbody2D myBody;
    private Animator anim;
	// Use this for initialization
	void Start () {
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {
        move();
	}
    void move()
    {
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            forceX = speed;
            Vector2 temp = transform.position;
            temp.x += speed * Time.deltaTime;
            transform.position = temp;
            anim.SetBool("Walk", true);
        }
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            forceX = -speed;
            Vector2 temp = transform.position;
            temp.x += -speed * Time.deltaTime;
            transform.position = temp;
            anim.SetBool("Walk", true);

        }
        else if (Input.GetKey(KeyCode.Space))
        {
            forceY = jump;
            Vector2 temp = transform.position;
            temp.y += jump * Time.deltaTime;
            transform.position = temp;
        }
         








    }
}
