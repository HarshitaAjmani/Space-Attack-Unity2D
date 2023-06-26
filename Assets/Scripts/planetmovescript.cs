using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planetmovescript : MonoBehaviour
{
    
    public float move_speed = 5;
    public float deadzone = -23;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(transform.position.x < deadzone){
            Debug.Log("Planet Deleted");
            Destroy(gameObject);
       }
       transform.position += Vector3.left * move_speed * Time.deltaTime; 
    }
}
