using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour {
    private float speed=1f;
    private Rigidbody2D myBody;
    private Animator anim;
	// Use this for initialization
	void Awake () {
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Walk();
	}
    void Walk()
    {
        // myBody.velocity = new Vector2(speed*Time.deltaTime, 0);
        Vector2 temp = transform.position;
        temp.x += speed * Time.deltaTime;
        transform.position = temp;
        

    }
   /* private void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "Enemy")
        {
            anim.SetBool("Die", true);
        }
    }*/
}
