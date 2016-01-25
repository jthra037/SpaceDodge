using UnityEngine;
using System.Collections;

public class hazardMover : MonoBehaviour {
	private Rigidbody rb;
	private GameObject player;
	public float speed;

	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
		player = GameObject.FindGameObjectWithTag ("Player");
		rb.velocity = transform.forward * speed; 
	}

	void Update () {
		float turnSpeed = player.GetComponent<playerController> ().movement;
		rb.velocity = (transform.forward * speed) + (transform.right * -turnSpeed);
	}
}
