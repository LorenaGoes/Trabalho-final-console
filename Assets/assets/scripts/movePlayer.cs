using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour {

    public float movMulti;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float posX = transform.position.x + Input.GetAxisRaw("Horizontal") * Time.deltaTime * movMulti;
        transform.position = new Vector3(Mathf.Clamp(posX, -10, 10), -4.3f, 0);
    }
}
