using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour {

    public float movMulti;
    public GameObject TiroPrefab;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float posX = transform.position.x + Input.GetAxisRaw("Horizontal") * Time.deltaTime * movMulti;
        transform.position = new Vector3(Mathf.Clamp(posX, -10, 10), -4.3f, 0);
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(TiroPrefab, transform.position, Quaternion.identity);
        }
    }
}
