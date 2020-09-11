using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMov : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 userInput;

    public bool isGrounded;
    public float movSpeed = 0.15f;
    public float jumpStr = 10f;
    // float grav = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
      rb = transform.GetComponent<Rigidbody2D>();
      print("Duck inited");
      print(transform.position);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {
      // Horizontal Movement
      userInput.Set(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
      // Debug.DrawRay(transform.position, userInput*2, Color.red);
      transform.Translate(userInput * movSpeed);


      if (isGrounded == false)
      {
      //   transform.Translate(-Vector2.up * grav);
      }
      else
      {
        // Jumping
        if (Input.GetButton("Jump"))
        {
          rb.velocity = Vector2.up * jumpStr;
        }
      }
    }


    private void OnCollisionEnter2D(Collision2D collidor){
      isGrounded = true;
    }
    private void OnCollisionExit2D(Collision2D collidor){
      isGrounded = false;
    }
}
