using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    public bool isMovingForward;
   public Vector3 MoveForward(float speed, float maxDistance, Vector3 cubeTrans)
  {
    if(maxDistance>=cubeTrans.z)
    {
        isMovingForward=true;
        cubeTrans+=Vector3.forward*speed*Time.deltaTime;
        return cubeTrans;
    }
    else
    {
        isMovingForward=false;
        return cubeTrans;
    }
  }
  public Vector3 MoveBack(float speed, float minDistance, Vector3 cubeTrans)
  {
    if(minDistance<=cubeTrans.z)
    {
        isMovingForward=false;
        cubeTrans+=Vector3.back*speed*Time.deltaTime;
        return cubeTrans;
    }
    else
    {
        isMovingForward=true;
        return cubeTrans;
    }
  }
}