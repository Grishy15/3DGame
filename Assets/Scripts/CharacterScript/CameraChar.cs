using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChar : MonoBehaviour
{
    private Transform trCamera;
    public Transform trChar;
    private Vector3 offset; 
    public float minAngle = -70;
    public float maxAngle = 70;
    [SerializeField]private float sensitivity = 80;
    private float x;
    private float y;
    private void Awake()
    {
        trCamera = GetComponent <Transform>();
    }
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; 
        offset = trCamera.position - trChar.position;
    }
    private void LateUpdate()
    {
        Vector3 directions = InputAxis();
        FollowCamera(directions);
    }
    private void FollowCamera(Vector3 inputAxis)
    {
        y = Mathf.Clamp(y, minAngle, maxAngle);
        trCamera.localEulerAngles = inputAxis;
        trCamera.position = trCamera.localRotation * offset + trChar.position;
    }
    private Vector3 InputAxis()
    {
        x += Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        y -= Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
        return new Vector3(y,x,0);
    }
}
