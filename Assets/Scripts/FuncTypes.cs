using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuncTypes : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform cubeTransform;
    public Rigidbody cubeRigidbody;
    public float speedMove=3;
    public float rotateAngle=45;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Funktsia Translate dvigaet obekt po glabalnim coordinati
        cubeTransform.Translate(Vector3.up * speedMove * Time.deltaTime); //Time.deltaTime sglashivaet i delaet plavnim sddvishenie
        //cubeTransform.position += cubeTransform.up * speedMove * Time.deltaTime; //Eto dvigat po localnim coordinatom
        cubeTransform.Rotate(new Vector3(45,45,45));
    }
}
