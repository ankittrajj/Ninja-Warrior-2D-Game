using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScaller : MonoBehaviour {

	// Use this for initialization
	void Start () {
        var height = Camera.main.orthographicSize * 2;
        var width = height * Screen.width / Screen.height;

        if (gameObject.name == "BG")
        {
            transform.localScale = new Vector2(width, height);
        }
        else
        {
            transform.localScale = new Vector2(width + 3, 5);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
