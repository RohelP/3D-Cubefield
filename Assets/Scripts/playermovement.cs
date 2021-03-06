using UnityEngine;

public class playermovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardforce = 2000f;
    public float sidewaysforce = 500f; 


    // we marked this as "fixed update" because we are using it to mess with physics.
    void FixedUpdate()
    {
        // adds a forward force
        rb.AddForce(0, 0, forwardforce * Time.deltaTime);


        if ( Input.GetKey("d"))
        {
            rb.AddForce(sidewaysforce * Time.deltaTime , 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -2.1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }

}
