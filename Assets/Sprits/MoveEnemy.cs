using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    
    float deadzone = -12;
    logicScript logic;
    public static float globalMoveSpeed = 10;
 
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicScript>();
     
         
    }

    // Update is called once per frame
    void Update()
    {
            transform.position += Vector3.left * (globalMoveSpeed * Time.deltaTime);    // di chuyen enemy
        if(transform.position.x < deadzone)
        {
            Destroy(gameObject);
        }


    }


}
