using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise1 : MonoBehaviour
{
    //Limits of the scene.
    private float xLimit = 8.35f;
    private float yLimit = 4.35f;

    public int Enemies = 1;

    private int Wave = 1;

    public GameObject prefapSphere;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        //Bucle
        if (Enemies == 0)
        {
            Wave++;
            Enemies = Wave;

            for (int i = 0; i < Wave; i++)
            {
                //Instaniate de sphere
                Instantiate(prefapSphere, RandomPosition(), prefapSphere.transform.rotation);
            }
           
           
        }
    }

    //Appier ina ramdom position
    private Vector3 RandomPosition()
    {
        return new Vector3(Random.Range(-xLimit, xLimit), Random.Range(-yLimit, yLimit), 0);
    }

  
}
