using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform2 : MonoBehaviour
{
  public float minDistanceY=0;
  public float maxDistanceY=20;
  public bool isMovingUp;
  private Transform cubeTrans;

  private void Awake()
  {
    cubeTrans=GetComponent<Transform>();
  }
  private void Update()
  {
    if(isMovingUp)
    {
        MoveUp();
    }
    else
    {
        MoveDown();
    }
  }
  private void MoveUp()
  {
    if(maxDistanceY>cubeTrans.position.y)
    {
        isMovingUp=true;
        cubeTrans.position+=Vector3.up*10*Time.deltaTime;
    }
    else
    {
        isMovingUp=false;
    }
  }
  private void MoveDown()
  {
    if(minDistanceY<cubeTrans.position.y)
    {
        isMovingUp=false;
        cubeTrans.position+=Vector3.down*10*Time.deltaTime;
    }
    else
    {
        isMovingUp=true;
    }
  }
}
