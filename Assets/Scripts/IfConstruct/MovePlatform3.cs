using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform3 : MonoBehaviour
{
  public float minDistanceX=0;
  public float maxDistanceX=20;
  public bool isMovingRight;
  private Transform cubeTrans;

  private void Awake()
  {
    cubeTrans=GetComponent<Transform>();
  }
  private void Update()
  {
    if(isMovingRight)
    {
        MoveRight();
    }
    else
    {
        MoveLeft();
    }
  }
  private void MoveRight()
  {
    if(maxDistanceX>cubeTrans.position.x)
    {
        isMovingRight=true;
        cubeTrans.position+=Vector3.right*10*Time.deltaTime;
    }
    else
    {
        isMovingRight=false;
    }
  }
  private void MoveLeft()
  {
    if(minDistanceX<cubeTrans.position.x)
    {
        isMovingRight=false;
        cubeTrans.position+=Vector3.left*10*Time.deltaTime;
    }
    else
    {
        isMovingRight=true;
    }
  }
}