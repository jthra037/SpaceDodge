using UnityEngine;
using System.Collections;

public class destroyByContact : MonoBehaviour {
	void OnTriggerEnter (Collider other){
		if (other.tag == "Boundary" || other.tag == "Enemy") {
			return;
		}
		/*Instantiate (explosion, transform.position, transform.rotation);
		if (other.tag == "Player") {
			Instantiate (playerExplosion, other.transform.position, other.transform.rotation);
		}*/
		//gameController.AddScore (scoreValue);
		Destroy (other.gameObject);
		Destroy (gameObject);
	}
}
