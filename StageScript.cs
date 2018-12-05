using UnityEngine;
using System.Collections;

public class StageScript : MonoBehaviour {
	
	public int stage;
	bool newTurnTrigger=false;

	GameObject buildingPanel;
	ElementScript es;
	//GameObject buildingPanelP2;
	BuildingScript bp;
	GameObject aiPanel;
	AIEventScript ae;
	GameObject turns;
	TurnsScript ts;

	GameObject introPanel;

	// Use this for initialization
	void Start () {
		
		stage = 1;

		buildingPanel = GameObject.Find ("BuildingPanel");
		//es = buildingPanelP1.GetComponent<ElementScript> ();

		//buildingPanelP2 = GameObject.Find ("BuildingPanelP2");
		//bp = buildingPanelP2.GetComponent<BuildingScript> ();

		aiPanel = GameObject.Find ("AIPanel");
		ae = aiPanel.GetComponent<AIEventScript> ();

		turns = GameObject.Find ("Turns");
		ts = turns.GetComponent<TurnsScript> ();

		introPanel = GameObject.Find ("IntroPanel");
	}
	
	// Update is called once per frame
	void Update () {


		if (stage == 1) 
		{


			buildingPanel.SetActive (true);
			//buildingPanelP2.SetActive (false);
			ae.gameObject.SetActive (false);

			ts.playerTurnText.color = Color.blue;
			ts.playerTurn = "Player 1";
			if (newTurnTrigger) 
			{
				ts.turns++;
				newTurnTrigger = false;
			}
		}
		else if (stage == 2) 
		{
			if (introPanel != null) 
			{
				introPanel.SetActive (true);
			}
			buildingPanel.SetActive (true);
			//buildingPanelP1.SetActive (false);
			ae.gameObject.SetActive (false);

			ts.playerTurnText.color = Color.red;

			ts.playerTurn = "Player 2";
		}
		else if (stage == 3) 
		{
			ae.gameObject.SetActive (true);
			buildingPanel.SetActive (false);
			//buildingPanelP2.SetActive (false);
			ts.playerTurnText.color = Color.green;

			ts.playerTurn = "Earth";
			newTurnTrigger = true;
		}
	}


}
