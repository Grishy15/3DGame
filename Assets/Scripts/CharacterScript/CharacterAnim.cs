using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnim : MonoBehaviour
{
   private Animator anim;
   private float speedAnim = 0.5f;
   private float smoothToggle = 0.1f;

   void Awake()
   {
        anim = GetComponent<Animator>();
   } 
   public void MoveAnim(Vector3 inputAxis)
   {
     speedAnim = Input.GetKey(KeyCode.LeftShift)? 1 : 0.5f;
        if (inputAxis.sqrMagnitude>0.2f)
        {
            anim.SetFloat("Horizontal",inputAxis.x * speedAnim, smoothToggle, Time.deltaTime);
            anim.SetFloat("Vertical",inputAxis.z * speedAnim, smoothToggle, Time.deltaTime);
        }
        else
        {
            anim.SetFloat("Horizontal", 0, smoothToggle, Time.deltaTime);
            anim.SetFloat("Vertical", 0, smoothToggle, Time.deltaTime);
        }
   }
   public void JumpAnim(bool isJump)
   {
        anim.SetBool("isJumping", isJump);
   }
}
