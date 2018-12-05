using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class IntroPanelScript : MonoBehaviour {

	Text Log;

	GameObject stage;
	StageScript ss;

	// Use this for initialization
	void Start () {
		Log = transform.Find ("LogText").GetComponent<Text> ();

	
		Log.color = new Color (1, 1, 1, 1);

		stage = GameObject.Find ("Stage");
		ss = stage.GetComponent<StageScript> ();

	}
	
	// Update is called once per frame
	void Update () {
	

		if (ss.stage == 1)
		{
			Log.text = "Reach 3,000 followers to win";
		} 
		else if (ss.stage == 2) 
		{
			Log.text = "Earn $3,000 to win";
		} 
	
	}

	public void OnCloseClick()
	{
		if (ss.stage == 2) {
			Destroy (this.gameObject);
		} else {
			this.gameObject.SetActive (false);
		}
	}
}
