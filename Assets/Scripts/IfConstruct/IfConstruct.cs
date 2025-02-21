using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfConstruct : MonoBehaviour
{   
    public bool isZombieFollowing;
    public float minDistance=12;
    public Transform curDistance;
    // Start is called before the first frame update
    private void PickupGun()
    {
        Debug.Log("You Already Picked Up The Gun");
    }

    // Update is called once per frame
    private void Update()
    {   
        ZombieChase();
        CheckDistance();
    }
    private void ZombieChase()
    {
        if(isZombieFollowing)
        {
            Debug.Log("Zombie Is Chasing You");
        }
        else
        {
            Debug.Log("Zombie Is Not Chasing You");
        }
    }
    private void CheckDistance()
    {
        if(minDistance>curDistance.position.z)
        {
            isZombieFollowing=true;
        }
        else 
        {
            isZombieFollowing=false;
        }
    }
    private void InputMouseButton()
    {
        if(Input.GetMouseButtonDown(0))
        {
            PickupGun();
        }
        else
        {
           Debug.Log("No Gun");
        }
    }
    private void InputKey()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            PickupGun();
        }
        else
        {
            Debug.Log("No Gun");
        }
    }
}
