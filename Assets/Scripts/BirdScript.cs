using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody2D;
    public LogicScript logicObject;
    public AudioSource audioObject;
    public float flapStrength;
    public bool isAlive = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isAlive)
        {
            myRigidbody2D.velocity = Vector2.up * flapStrength;
            audioObject.Play();
        }        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isAlive = false;
        logicObject.gameOver();
    }
}
