using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LogScript : MonoBehaviour {
	
	Text logText;


	public string logContent;
	//GameObject turnTextOj;


	// Use this for initialization
	void Start () {

		logContent = "";
		logText=transform.Find ("Log").GetComponent<Text>();
	
	}

	// Update is called once per frame
	void Update () {
		
		logText.text = logContent;
	}
}
