using UnityEngine;
using System.Collections;

public class TempRain : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//transform.Translate(Vector3.forward * Time.deltaTime);
		transform.localPosition+=new Vector3(0f,0f,0.001f);
		Destroy(this.gameObject, 0.3f);
	}
}
