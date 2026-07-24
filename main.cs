// CSharp - Unity - Create a Enemy Shift Mechanics:  
// Enemy Mechanic is an enemy shift script that switches the Player's controls from the..
// .. Player to the Enemy:

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMechanics : MonoBehaviour
{
    public GameObject enemy;
    public GameObject player;

    [SerializeField] Transform playerT;
    [SerializeField] Vector3 offset;
    
    void Start()
    {
        Print("Kelly 02"); //    
    
    }
        
    void Update()
    {
        if(Input.GetKeyDown("KeyCode").W)
        {
            transform.position = player.position + offset;
        }  
                
        if(Input.GetKeyDown("KeyCode").S + T)
        {
            print("Try programiz.pro");
        }
        
        else if()
        {
            
            
        }
        
    }

    void FollowTarget(Transform playerT, Vector3 offset)
    {
        //  public Camera camPlayer;
        this.playerT = playerT;
        this.offset = offset;
        
        if()
        {
            positio
        }


    }
        
}


