using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // This is a reference to the player's rigidBody component
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

	// We use FixedUpdate instead of Update because
    // we are manipulating with physics
	void FixedUpdate () {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //Add a forward force on the z axis

        if (Input.GetKey("d")) //if d pressed, move right
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a")) //if a is pressed, move left
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1)
        {
            FindObjectOfType<Manager>().EndGame();
        }
    }
}
