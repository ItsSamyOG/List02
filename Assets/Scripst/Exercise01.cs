using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise01 : MonoBehaviour
{

    private Exercise1 Exercise1_Script;

    void Start()
    {
        //We conect to the other script
        Exercise1_Script = FindObjectOfType<Exercise1>();
    }

    private void OnMouseDown()
    {
        //Destroy rhe gameobject
        Exercise1_Script.Enemies--;
        Destroy(gameObject);
    }

   
}
