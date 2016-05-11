using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform target;
	public float m_speed = 0.2f;
	Camera mycam;


	// Use this for initialization
	void Start () {
	
		mycam = GetComponent<Camera> ();


	}
	
	// Update is called once per frame
	void Update () {
	
		mycam.orthographicSize = (Screen.height / 100f) / 4f;

		if (target) {
			/* m_speed determines how quickly the camera starts up and stops when the target stops moving
			 * the -10 for Z moves the camera out so it is not literally on the player
			 */
			
			transform.position = Vector3.Lerp (transform.position, target.position, m_speed) + new Vector3(0,0,-10);

	}
}
}