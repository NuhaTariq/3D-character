using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour
{
    private Animator animComp;
    private enum CharacterController { Ideal = 0, walking = 1, run = 2, jump = 3, sit = 4 };
    private int movmentState;

    void Start()
    {
        animComp = this.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            movmentState = (int)CharacterController.walking;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            movmentState = (int)CharacterController.Ideal;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            movmentState = (int)CharacterController.run;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            movmentState = (int)CharacterController.Ideal;
        }
        


        animComp.SetInteger("StudentState", movmentState);
    }
}

