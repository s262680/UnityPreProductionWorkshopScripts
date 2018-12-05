using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class AIEventScript : MonoBehaviour {

	GameObject stage;
	StageScript ss;
	GameObject turns;
	TurnsScript ts;
	GameObject resources;
	ResourcesManager rm;
	public bool onceTrigger=true;

	Text P1ResultLog;
	Text P2ResultLog;

	Text eventLog;

	GameObject[] allLandOJ;
	List<GameObject> buildingLandOJ=new List<GameObject>();

	int eventCase;

	// Use this for initialization
	void Start () {
		stage = GameObject.Find ("Stage");
		ss = stage.GetComponent<StageScript> ();
		turns = GameObject.Find ("Turns");
		ts = turns.GetComponent<TurnsScript> ();
		resources = GameObject.Find ("Resources");
		rm = resources.GetComponent<ResourcesManager> ();


		P1ResultLog = transform.Find ("P1Result").GetComponent<Text> ();
		P2ResultLog = transform.Find ("P2Result").GetComponent<Text> ();
		eventLog = transform.Find ("EventLog").GetComponent<Text> ();
		P1ResultLog.color = new Color (0, 0, 1, 1);
		P2ResultLog.color = new Color (1, 0, 0, 1);
		eventLog.color = new Color (0, 1, 0, 1);


	}
	
	// Update is called once per frame
	void Update () 
	{


		P1ResultLog.text="Player 1 has gained "+rm.p1PopAffect+" population and " +rm.p1MoneyAffect+" money and lost "+rm.p1PopNegAffect + " population due to land destoryed "+ " in this turn!";
		P2ResultLog.text="Player 2 has gained "+rm.p2PopAffect+" population and " +rm.p2MoneyAffect+" money and lost "+rm.p2PopNegAffect + " population due to land destoryed "+ " in this turn!";


		if (onceTrigger) 
		{
			eventCase = Random.Range (1, 5);

			switch(eventCase)
			{
			case 1:
				eventLog.text = "EVENT: Oh no! A random Building got Destroyed!!";

				if (Random.value > 0.5) 
				{
					allLandOJ = GameObject.FindGameObjectsWithTag ("P1Building");
					foreach (GameObject buildings in allLandOJ) 
					{
						if (buildings.transform.childCount > 0) 
						{
							buildingLandOJ.Add (buildings);
						}
					}
					Destroy (buildingLandOJ [Random.Range (0, buildingLandOJ.Count)].transform.parent.gameObject);
				
				} 
				else 
				{
					allLandOJ = GameObject.FindGameObjectsWithTag ("P2Building");
					foreach (GameObject buildings in allLandOJ)
					{
						if (buildings.transform.childCount > 0)
						{
							buildingLandOJ.Add (buildings);
						}
					}
					Destroy (buildingLandOJ [Random.Range (0, buildingLandOJ.Count)].transform.parent.gameObject);
				}
				break;
			case 2:
				eventLog.text = "EVENT: Oh no! A flood has occurred, all players's Population decrease by 100!!";
				rm.popP1 -= 100;
				rm.popP2 -= 100;
				break;
			case 3:
				eventLog.text = "EVENT: Oh no! A flood has occurred, all players's Money decrease by 100!!";
				rm.moneyP1 -= 100;
				rm.moneyP2 -= 100;
				break;
			case 4:
				eventLog.text = "EVENT: Oh no! something something has occurred, all seaside building got destoryed!!";
				//fake
				break;
			}

				onceTrigger = false;
		}
	
		//if(ts.turns%2==0)
		//{

		/*
			if (onceTrigger) 
			{

			if (rm.eleSelect == "water"&&Random.value >(1-rm.water/400)) 
				{
				
						//event happen
						eventLog.text = "EVENT: Oh no! A flood has occurred, water has been increase by 10, and heat has decreased by 10, population has decreased by 5, energy has decreased by 10!!";
						rm.eventTrigger = true;
						rm.eventType = "WaterFlood";
						onceTrigger = false;
					
				}
			else if (rm.eleSelect == "heat"&&Random.value > (1-rm.heat / 400)) 
				{
					
						//event happen
						eventLog.text = "EVENT: A heat wave has occurred, heat has been increased by 10, and water has decreased by 10, population has decreased by 5!!";
						rm.eventTrigger = true;
						rm.eventType = "OverHeat";
						onceTrigger = false;
					
				}
			else if ((rm.eleSelect == "heat"||rm.eleSelect=="water")&&Random.value > (1-rm.energy / 400)) 
				{
					
						//event happen
						eventLog.text = "EVENT: In a freak accident the power plant has failed, energy has been decreased by 10 and heat has increased by 10!!";
						rm.eventTrigger = true;
						rm.eventType = "PowerPlantFailed";
						onceTrigger = false;
					
				}
				else
				{
					//nothing happen
					eventLog.text="EVENT: A peaceful year, nothing happens.";
					onceTrigger = false;
				}
			}

		*/

		//}
		//else if(ts.turns%2==1)
	
	}

	public void OnNext()
	{
		rm.p1PopAffect = 0;
		rm.p1MoneyAffect = 0;
		rm.p2PopAffect = 0;
		rm.p2MoneyAffect = 0;
		rm.p1PopNegAffect = 0;
		rm.p2PopNegAffect = 0;

		onceTrigger = true;
		ss.stage = 1;
	}
}
