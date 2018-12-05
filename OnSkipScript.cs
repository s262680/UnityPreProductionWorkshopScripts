using UnityEngine;
using System.Collections;

public class OnSkipScript : MonoBehaviour {

	GameObject stage;
	StageScript ss;
	public ResourcesManager rm;

	// Use this for initialization
	void Start () {
		stage = GameObject.Find ("Stage");
		ss = stage.GetComponent<StageScript> ();

	}
	
	// Update is called once per frame
	void Update () 
	{
		rm.ResourceUpdate();
		if (rm.onceTrigger == true)
		{
			Debug.Log ("Hello, we have reached this point in the script");
		}
	}

	public void OnSkip()
	{
		if (ss.stage == 1) 
		{
			ss.stage = 2;
		}
		else if (ss.stage == 2) 
		{
			ss.stage = 3;
			rm.onceTrigger = true;
		}

		//Clicking skip on turn 3 would cause a bug where players pop/moneyrate values would
		//stay as they were at the end of the turn, leading to generations of 1000's of resources
		//It would go to 0 if they clicked "Next", but "Skip" was still clickable, so we take that
		//functionality out, easy fix to prevent the bug

		/*
		else if (ss.stage == 3) 
		{
			ss.stage = 1;
		}
		*/
	}
}
