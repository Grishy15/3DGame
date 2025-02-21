using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionTest : MonoBehaviour
{
    public float EnemyHP = 10.5f;
    public float PlayerHP = 11.5f;
    public int EnemyDamage = 11;
    public string Name = "Gosha";
    //Tip danih otnositsa k igrovim obiektam 
    private GameObject Player; 
    //Tip danih otnositsa k componentam na obiektah
    public Rigidbody Gravity;
    public Transform cubeTransform;
    private Collider EnemyCollider;
    //Tip danih otnositsa k igrovim assetam
    public Material cubeMaterial; 
    // Vse functiee srabativaiut pri nalichie etovo scripta na nushnom obekte
    private void Awake()
    {
        Debug.Log("Awake");
    }
    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }
    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }
    private void OnDestroy()
    {
       Debug.Log("OnDestroy");
    }
    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log("start");
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
    // OnCollision i OnTrigger rabotaiut pri uslovie nalichie componenta RigidBody na dvishaiushem obekte i pri nalichie collidera na vseh obiektah
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name + " Stuknul kubik");
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log(collision.gameObject.name + " Prikasaetsia k kubiku");
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log(collision.gameObject.name + " Perestal prikasatsia");
    }
    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log(collider.gameObject.name + " Zashol v Trigger");
    }
    private void OnTriggerStay(Collider collider)
    {
        Debug.Log(collider.gameObject.name + " Nahoditsa v Triggere");
    }
    private void OnTriggerExit(Collider collider)
    {
        Debug.Log(collider.gameObject.name + " Vishel iz Triggera");
    }
    private void OnMouseDown()
    {
        Debug.Log("Click Down");
        cubeTransform.localScale = new Vector3(2,2,2);
    }
    private void OnMouseUp()
    {
        Debug.Log("Click Up");
        cubeTransform.localScale = new Vector3(1,1,1);
    }
    private void OnMouseEnter()
    {
        Debug.Log("Enter");
        cubeMaterial.color = Color.red;
    }
    private void OnMouseExit()
    {
        Debug.Log("Exit");
        cubeMaterial.color = Color.blue;
    }

}
