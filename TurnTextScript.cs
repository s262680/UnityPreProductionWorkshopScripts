using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TurnTextScript : MonoBehaviour {
	
	Text animTurnText;
	GameObject stage;
	StageScript ss;
	float speed=0;
	public bool trigger=false;
	int tempStage=0;

	// Use this for initialization
	void Start () {
		stage = GameObject.Find ("Stage");
		ss = stage.GetComponent<StageScript> ();
		animTurnText=GetComponent<Text>();
		animTurnText.text = "";

	}
	
	// Update is called once per frame
	void Update () {
		if (trigger) 
		{
			if (animTurnText.rectTransform.anchoredPosition.x < Screen.width / 3 || animTurnText.rectTransform.anchoredPosition.x > Screen.width / 1.5f) 
			{
				speed = 40.0f;
			}
			else 
			{
				speed = 7f;
			}
		}
		if (animTurnText.rectTransform.anchoredPosition.x > Screen.width + 100) 
		{
			trigger = false;
			speed = 0;
			animTurnText.rectTransform.anchoredPosition = new Vector2 (-500, 200.0f);

		}
		if (ss.stage == 1) 
		{
			animTurnText.color=new Color(0,0,1,1);
			animTurnText.text = "Player 1's Turn";		
			// Earn as much money as possible.
			animTurnText.rectTransform.anchoredPosition += new Vector2 (speed, 0.0f);
		}
		else if (ss.stage == 2) 
		{
			
			animTurnText.color=new Color(1,0,0,1);
			animTurnText.text = "Player 2's Turn";
			// /n Recruit as many followers as possible.
			animTurnText.rectTransform.anchoredPosition += new Vector2 (speed, 0.0f);

		}
		else if (ss.stage == 3) 
		{
			animTurnText.color=new Color(0,1,0,1);
			animTurnText.text = "Turn's Result";
			animTurnText.rectTransform.anchoredPosition += new Vector2 (speed, 0.0f);

		}

		if (tempStage != ss.stage) 
		{
			trigger = true;
			tempStage = ss.stage;
		}
	}


}
