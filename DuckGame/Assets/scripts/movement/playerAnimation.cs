using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAnimation : MonoBehaviour
{
    public Animator animator;
    private playerMov parent;
    // Start is called before the first frame update
    void Start()
    {
        parent = this.transform.parent.GetComponent<playerMov>();
    }

    // Update is called once per frame
    // get current Player state and adjust animator state
    void Update()
    {
        // check if on ground
        if (parent.isGrounded){
            animator.SetBool("isGrounded", true);
        }else{
            animator.SetBool("isGrounded", false);
        }

        //check if jumping
        if (Input.GetButton("Jump")){
            animator.SetBool("jumping", true);
        }else{
            animator.SetBool("jumping", false);
        }

        // check if moving sideways
        if (Input.GetAxis("Horizontal") != 0){
            animator.SetBool("moveSideways", true);
        }else{
            animator.SetBool("moveSideways", false);
        }
    }
}
