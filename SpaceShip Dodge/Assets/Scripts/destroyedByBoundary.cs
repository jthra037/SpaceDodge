using UnityEngine;
using System.Collections;

public class destroyedByBoundary : MonoBehaviour {
	void OnTriggerExit (Collider other)
	{
		Destroy (other.gameObject);
		Debug.Log (other.name);
	}
}
