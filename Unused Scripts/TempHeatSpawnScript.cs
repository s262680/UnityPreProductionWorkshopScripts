using UnityEngine;
using System.Collections;

public class TempHeatSpawnScript : MonoBehaviour {

	public GameObject effectFab;

	// Use this for initialization
	void Start () {

	}
	void Update () {
		spawnEffects();

	}


	public void spawnEffects()
	{
		GameObject heat = (GameObject)Instantiate(effectFab, transform.position+new Vector3(Random.Range(-0.25f,0.25f),Random.Range(-0.25f,0.25f),Random.Range(-0.05f,0.05f)),transform.rotation);
		heat.name = "effects";
		heat.transform.parent = transform;
	}
}