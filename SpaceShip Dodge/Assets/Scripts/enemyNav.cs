using UnityEngine;
using System.Collections;

public class enemyNav : MonoBehaviour {
	private GameObject player;
	NavMeshAgent agent;
	public float speed = -60;
	public float sensitivity;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		agent = GetComponent<NavMeshAgent> ();
	}

	// Update is called once per frame
	void Update () {
		float turnSpeed = player.GetComponent<playerController> ().movement * sensitivity;
		Vector3 agentAdjust = new Vector3 (-turnSpeed, 0.0f, 0.0f);
		agent.Move (agentAdjust);
	}

	void LateUpdate (){
		agent.SetDestination (player.transform.position);
		if (transform.position.z < player.transform.position.z) {
			Destroy (gameObject);
		}
		Debug.Log (transform.position);
	}
}
