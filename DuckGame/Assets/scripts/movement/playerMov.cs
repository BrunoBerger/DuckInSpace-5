using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMov : MonoBehaviour
{
    Vector2 userInput;
    float movSpeed = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
      print("Duck inited");
      print(transform.position);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {
      userInput.Set(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
      Debug.DrawRay(transform.position, userInput*2, Color.red);

      transform.Translate(userInput * movSpeed);
    }


    private void OnCollisionEnter2D(Collision2D collidor){
      print("On Ground");
    }
    private void OnCollisionExit2D(Collision2D collidor){
      print("left ground");
    }
}
