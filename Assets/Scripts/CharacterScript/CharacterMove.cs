using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public float speed=10;
    public float rotateSpeed=45;
    public float jumpForce=5;
    public bool isTerrain=false;
    private Rigidbody rbChar;
    private CharacterAnim anim;
    private CameraChar camera;
    private Transform camTrans;
    private Vector3 newDirections;
    private void Awake()
    {
        rbChar = GetComponent<Rigidbody>();
        anim = GetComponentInChildren<CharacterAnim>();
        camera = FindObjectOfType<CameraChar>();
        camTrans = camera.GetComponent<Transform>();
    }
    private void Update()
    {
        Vector3 directions = InputAxis();
        Rotate(directions);
        Move(newDirections);
        anim.MoveAnim(directions);
        Jumping(isTerrain);

    }
    private void Move(Vector3 inputAxis)
    {
        speed = Input.GetKey(KeyCode.LeftShift)? 10 : 4;
        rbChar.MovePosition(rbChar.position + inputAxis * speed * Time.deltaTime);
    }
    private Vector3 InputAxis()
    {
        float x=Input.GetAxis("Horizontal");
        float z=Input.GetAxis("Vertical");
        return new Vector3(x,0,z);
    }
    private void Rotate(Vector3 inputAxis)
    {
        Vector3 forward = Vector3.ProjectOnPlane(camTrans.forward,Vector3.up);
        Vector3 right = Vector3.ProjectOnPlane(camTrans.right,Vector3.up);
        newDirections = (inputAxis.z * forward) + (inputAxis.x * right);
        Quaternion rotation = Quaternion.LookRotation(forward, Vector3.up);
        Quaternion rotateLerp = Quaternion.Lerp(rbChar.rotation, rotation, Time.deltaTime * rotateSpeed);
        rbChar.MoveRotation(rotateLerp);
    }
    private void Jumping(bool isTerrain)
    {
        if (Input.GetKeyDown(KeyCode.Space)&& isTerrain)
        {
            rbChar.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            anim.JumpAnim(true);
        }
        else anim.JumpAnim(false);
    }
    private void OnCollisionEnter(Collision col)
    {
        isTerrain=true;
    }
    private void OnCollisionExit(Collision col)
    {
        isTerrain=false;
    }
}
