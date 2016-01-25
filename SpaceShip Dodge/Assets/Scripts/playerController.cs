using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {
	public float speed;
	public float tiltAngle;
	public float smooth;
	public float movement;

	void Start () {

	}
	// Update is called once per frame
	/*void Update () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float movement = moveHorizontal * speed;
		Vector3 tiltAmount = new Vector3 (0.0f, 0.0f, movement * -tilt);
		if (
		transform.Rotate (tiltAmount * Time.deltaTime);
	}*/

	void Update () {
		float tiltAroundZ = Input.GetAxis ("Horizontal") * -tiltAngle;
		movement = speed * Input.GetAxis ("Horizontal");
		Quaternion target = Quaternion.Euler (0, 0, tiltAroundZ);
		transform.rotation = Quaternion.Slerp (transform.rotation, target, Time.deltaTime * smooth);
	}
}