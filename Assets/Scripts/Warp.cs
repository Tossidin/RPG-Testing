using UnityEngine;
using System.Collections;

public class Warp : MonoBehaviour {


	public Transform warpTarget;

	IEnumerator OnTriggerEnter2D(Collider2D other){

		Screenfader sf = GameObject.FindGameObjectWithTag ("Fader").GetComponent<Screenfader> ();

		yield return StartCoroutine (sf.FadeToBlack ());

		other.gameObject.transform.position = warpTarget.position;
		Camera.main.transform.position = warpTarget.position;


		yield return StartCoroutine (sf.FadeToClear ());
	}
}