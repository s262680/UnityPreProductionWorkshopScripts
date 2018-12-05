using UnityEngine;
using System.Collections;

public class TempHeat : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.localPosition+=new Vector3(Random.Range(-0.002f,0.002f),Random.Range(-0.002f,0.002f),-0.001f);
		Destroy(this.gameObject, 1f);
	}
}
