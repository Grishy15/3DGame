using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
  public float minDistance=0;
  public float maxDistance=20;
  public bool isMovingForward;
  private Transform cubeTrans;
  private Functions func;
  public float speed;

  private void Awake()
  {
    func=GetComponent<Functions>();
    cubeTrans=GetComponent<Transform>();
  }
  private void Update()
  {
    if(isMovingForward)
    {
      cubeTrans.position=func.MoveForward(speed,maxDistance,cubeTrans.position); 
      isMovingForward=func.isMovingForward;
    }
    else
    {
      cubeTrans.position=func.MoveBack(speed,minDistance,cubeTrans.position);
      isMovingForward=func.isMovingForward;
    }
  }
  private void MoveForward()
  {
    if(maxDistance>cubeTrans.position.z)
    {
        isMovingForward=true;
        cubeTrans.position+=Vector3.forward*10*Time.deltaTime;
    }
    else
    {
        isMovingForward=false;
    }
  }
  private void MoveBack()
  {
    if(minDistance<cubeTrans.position.z)
    {
        isMovingForward=false;
        cubeTrans.position+=Vector3.back*10*Time.deltaTime;
    }
    else
    {
        isMovingForward=true;
    }
  }
}
