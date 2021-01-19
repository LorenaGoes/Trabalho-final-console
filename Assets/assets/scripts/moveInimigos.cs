using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveInimigos: MonoBehaviour {
    private float contMov = 0;
    gamemaneger gManager;
    GameObject inObj;
    public int vida;

    // Use this for initialization
    void Start()
    {
        gManager = GameObject.Find("GameManager").GetComponent<gamemaneger>();
        inObj = GameObject.Find("Inimigos");
    }

    // Update is called once per frame
    void Update()
    {
        contMov += Time.deltaTime;

        if (contMov > 1)
        {
            if (gManager.bateuParede == false)
            {
                if (gManager.desce == false)
                {
                    transform.position += new Vector3(.2f, 0, 0);
                    contMov = 0;
                }
                else
                {
                    transform.position += new Vector3(.2f, 0, 0);
                    inObj.transform.position += new Vector3(0, -1, 0);
                    gManager.desce = false;
                    contMov = 0;
                }
            }
            else if (gManager.bateuParede == true)
            {
                if (gManager.desce == false)
                {
                    transform.position += new Vector3(-.2f, 0, 0);
                    contMov = 0;
                }
                else
                {
                    transform.position += new Vector3(-.2f, 0, 0);
                    inObj.transform.position += new Vector3(0, -1, 0);
                    gManager.desce = false;
                    contMov = 0;
                }
            }
        }
    }

    void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.gameObject.tag == "paredeDir")
        {
            gManager.bateuParede = true;
            gManager.desce = true;
        }
        else if (outro.gameObject.tag == "paredeEsq")
        {
            gManager.bateuParede = false;
            gManager.desce = true;
        }
        else if (outro.gameObject.tag == "tiro")
        {
            Destroy(outro.gameObject);
            vida--;

            if (vida<=0)
            {
                Destroy(gameObject);
            }
        }
    }
}