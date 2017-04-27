using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class movement : MonoBehaviour {

    // gravity constant
    public float g = 9.8f;

    void FixedUpdate()
    {
        // normalize axis
        var gravity = new Vector3(
           Input.acceleration.x,
            0,
            0
        ) * g;

		if (GetComponent<Rigidbody> ().position.x < 8 && GetComponent<Rigidbody> ().position.x > -8) 
		{
			GetComponent<Rigidbody> ().AddForce (gravity, ForceMode.Force);
		} 
		else if (GetComponent<Rigidbody> ().position.x > 9) 
		{
			GetComponent<Rigidbody> ().AddForce (-0.5F, 0, 0, ForceMode.Impulse);
		}
		else if (GetComponent<Rigidbody> ().position.x < -9) 
		{
			GetComponent<Rigidbody> ().AddForce (0.5F, 0, 0, ForceMode.Impulse);
		}
    }

}
