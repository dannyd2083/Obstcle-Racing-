
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

  public Rigidbody rb;
  public float forwardForce = 2000.0f;
  public float movespeed = 5.0f;
  public float jumpForce = 200.0f;
  // public float sideForce = 500f;
    // // Start is called before the first frame update
    // void Start()
    // {
    //
    // }

    // Update is called once per frame
    void FixedUpdate()
    {
      //  add a forward force

      rb.AddForce(0,0,forwardForce*Time.deltaTime);
      // if(Input.GetKey("d")){
      //   rb.AddForce(sideForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
      // }if(Input.GetKey("a")){
      //   rb.AddForce(-sideForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
      // }
      transform.Translate(Input.GetAxis("Horizontal")*Time.deltaTime*movespeed,0f,0f);


      if(rb.position.y < 0f){
        rb.constraints = RigidbodyConstraints.None;
        FindObjectOfType<GameManager>().EndGame();
      }


    }
}
