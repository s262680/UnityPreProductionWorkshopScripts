using UnityEngine;
using System.Collections;

public class RotationControl : MonoBehaviour {

	 float rotateSpeed;

	// Use this for initialization
	void Start () {
	
		rotateSpeed = 80;
	}
	
	// Update is called once per frame
	void Update () {

	}


	//when mouse click and drag on this object, run every frame
	void OnMouseDrag()
	{
		//input.getaxis get the rotate angle from start of each frame
		float rotRadX = Input.GetAxis ("Mouse X") *rotateSpeed * Mathf.Deg2Rad;
		float rotRadY = Input.GetAxis ("Mouse Y") *rotateSpeed * Mathf.Deg2Rad;
	
		//rotate around the centre of itself by the radian above
		transform.RotateAround (this.gameObject.transform.position,new Vector3(0,1,0), -rotRadX);
		transform.RotateAround (this.gameObject.transform.position,new Vector3(1,0,0), rotRadY);

	}
}
