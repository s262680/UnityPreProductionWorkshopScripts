using UnityEngine;
using System.Collections;

public class TempRainSpawnScript : MonoBehaviour {
	
	public GameObject effectFab;

	// Use this for initialization
	void Start () {

	}
	void Update () {
		spawnEffects();
		spawnEffects();
	}


	public void spawnEffects()
	{
		GameObject rain = (GameObject)Instantiate(effectFab, transform.position+new Vector3(Random.Range(-0.25f,0.25f),Random.Range(-0.25f,0.25f),0),transform.rotation);
		rain.name = "effects";
		rain.transform.parent = transform;
	}
}