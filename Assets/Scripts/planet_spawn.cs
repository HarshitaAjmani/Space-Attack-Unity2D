using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planet_spawn : MonoBehaviour
{
    public GameObject planet;
    public double spawnRate = 2.4;
    public float heightoffset = 4; 
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        spawn_planet();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate){
            timer += Time.deltaTime;
        }
        else{
            spawn_planet();
            timer = 0;
        }
       
    }

    //spawn code
    void spawn_planet(){
        float lowestPoint = transform.position.y - heightoffset;
        float highestPoint = transform.position.y + heightoffset;

        Instantiate(planet, new Vector3(transform.position.x, Random.Range(lowestPoint,highestPoint), 0) , transform.rotation); 
    }

}
