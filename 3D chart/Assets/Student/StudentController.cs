using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentController : MonoBehaviour
{
    private Animator animComp;
    void Start()
    {
        animComp = this.GetComponent<Animator>();
    }
    void Update()
    {
        //walking
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            animComp.SetInteger("StudentState", 1);
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            animComp.SetInteger("StudentState", 0);
        }
        //running
        if (Input.GetKeyDown(KeyCode.Space))
         {
           animComp.SetInteger("StudentState", 2);
        }
       if (Input.GetKeyUp(KeyCode.Space))
         {
           animComp.SetInteger("StudentState", 0);
        }

       //rotating left and right 
        if (Input.GetKey("left"))
        {
            transform.Rotate(0, 5, 0);
        }
        if (Input.GetKey("right"))
        {
            transform.Rotate(0, -5, 0);
        }
    }
}



