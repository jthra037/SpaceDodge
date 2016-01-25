using UnityEngine;
using System.Collections;

public class gameController : MonoBehaviour {
	private bool gameOver;

	public GameObject hazard;
	public GameObject enemy;
	public Vector3 spawnValues;

	public int hazardCount;
	public int enemyCount;
	public float enemyWait;
	public float spawnWait;
	public float startWait;
	public float waveWait;

	// Use this for initialization
	void Start () {
		gameOver = false;
		StartCoroutine (SpawnWaves ());
		StartCoroutine (SpawnEnemies ());
	}
	
	IEnumerator SpawnWaves (){
		yield return new WaitForSeconds (startWait);
		while (!gameOver)
		{
			for (int i = 0;i < hazardCount; i++) 
			{
				Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (hazard, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);
		}
		//restartText.text = "Press 'R' for Restart";
		//restart = true;
	}

	IEnumerator SpawnEnemies (){
		while (!gameOver) 
		{
			for (int i = 0; i < enemyCount; i++) 
			{
				Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (enemy, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (enemyWait);
			}
		}
	}
}
