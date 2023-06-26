using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipscript : MonoBehaviour
{
    //creating refrence to get access of rigid body in our script
    public Rigidbody2D my_rigidbody;
    public float flapstrenght = 4;
    public LogicScript logic;
    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            my_rigidbody.velocity = Vector2.up *flapstrenght;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
