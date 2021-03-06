using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	Rigidbody2D rbody;
	Animator anim;
	int speedMultiplier;

	// Use this for initialization
	void Start () {
		rbody = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
		speedMultiplier = 1;
	}

	// Update is called once per frame
	void Update () {
		determineSpeed ();
		Vector2 movement_vector = new Vector2 (Input.GetAxisRaw ("Horizontal"), Input.GetAxisRaw ("Vertical"));
		if (movement_vector != Vector2.zero) {
			anim.SetBool ("isWalking", true);
			anim.SetFloat ("input_x", movement_vector.x);
			anim.SetFloat ("input_y", movement_vector.y);
		} else {
			anim.SetBool ("isWalking", false);
		}

		rbody.MovePosition (rbody.position + (movement_vector * speedMultiplier ) * Time.deltaTime);
	}
	/**
	 * Private function for determining if the user is
	 * running or not. Are they pressing the space key?
	 * If so, set a speed multiplier of 2x.
	 * Otherwise, set a normal speed multiplier of 1x.
	 * 
	*/
	private void determineSpeed() {

		if (Input.GetKey (KeyCode.Space)) {
			speedMultiplier = 2;
		} else {
			speedMultiplier = 1;
		}
	}
}
