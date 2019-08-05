using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    // Use this for initialization
    private Animator anim;
    void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "Enemy")
        {
            Destroy(target.gameObject);
            anim.SetTrigger("Attack");
            //anim.SetBool("Die", true);
        }
        else if (target.gameObject.tag == "Enemy")
        {
            anim.SetBool("Die", true);
        }

    }
}
