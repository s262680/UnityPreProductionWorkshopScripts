using UnityEngine;
using System.Collections;

public class BuildingScript : MonoBehaviour {

	public int buildingSelection;


	GameObject resources;
	ResourcesManager rm;
	GameObject turns;
	TurnsScript ts;
	GameObject earthPanel;
	ElementScript es;
	GameObject logPanel;
	LogScript ls;
	GameObject stage;
	StageScript ss;


	// Use this for initialization
	void Start () {
		
		resources = GameObject.Find ("Resources");
		rm = resources.GetComponent<ResourcesManager> ();
		turns = GameObject.Find ("Turns");
		ts = turns.GetComponent<TurnsScript> ();
		//earthPanel = GameObject.Find ("EarthPanel");
		//es = earthPanel.GetComponent<ElementScript> ();
		logPanel = GameObject.Find ("LogPanel");
		ls = logPanel.GetComponent<LogScript> ();
		stage = GameObject.Find ("Stage");
		ss = stage.GetComponent<StageScript> ();

		buildingSelection = -1;
	}	

	// Update is called once per frame
	void Update () {
	}

	public void OnSolarPlantClick()
	{
		if (ss.stage == 1) 
		{
			if (rm.moneyP1 >= rm.solarMoneyCost && rm.popP1>rm.solarPopCost) 
			{
				buildingSelection = 0;
				ls.logContent = " Please select an empty space to place the building.";
			} 
			else 
			{
				ls.logContent = " Not enough money, please try another other building.";

			}
		}
		if (ss.stage == 2) 
		{
			if (rm.moneyP2 >= rm.solarMoneyCost && rm.popP2>rm.solarPopCost) 
			{
				buildingSelection = 0;
				ls.logContent = " Please select an empty space to place the building.";
			} 
			else 
			{
				ls.logContent = " Not enough money, please try another other building.";

			}
		}
	}

	public void OnGasPlantClick()
	{
		if (ss.stage == 1) 
		{
			if (rm.moneyP1 >= rm.solarMoneyCost && rm.popP1>rm.solarPopCost) 
			{
				buildingSelection = 1;
				ls.logContent = " Please select an empty space to place the building.";
			} 
			else 
			{
				ls.logContent = " Not enough money, please try another other building.";

			}
		}
		if (ss.stage == 2) 
		{
			if (rm.moneyP2 >= rm.solarMoneyCost && rm.popP2>rm.solarPopCost) 
			{
				buildingSelection = 1;
				ls.logContent = " Please select an empty space to place the building.";
			} 
			else 
			{
				ls.logContent = " Not enough money, please try another other building.";

			}
		}
	}

	public void OnNulclearPlantClick()
	{
		if (ss.stage == 1) 
		{
			if (rm.moneyP1 >= rm.nulclearMoneyCost && rm.popP1>rm.nulclearPopCost) 
			{
				buildingSelection = 2;
				ls.logContent = " Please select an empty space to place the building.";
			} 
			else 
			{
				ls.logContent = " Not enough money, please try another other building.";

			}
		}
		if (ss.stage == 2) 
		{
			if (rm.moneyP2 >= rm.nulclearMoneyCost && rm.popP2>rm.nulclearPopCost) 
			{
				buildingSelection = 2;
				ls.logContent = " Please select an empty space to place the building.";
			} 
			else 
			{
				ls.logContent = " Not enough money, please try another other building.";

			}
		}
	}

	public void OnCoalMineClick()
	{
		if (ss.stage == 1) 
		{
			if (rm.moneyP1 >= rm.coalMoneyCost && rm.popP1>=rm.coalPopCost)  
			{
				buildingSelection = 3;
				ls.logContent = " Please select an empty space to place the building.";
			} 
			else 
			{
				ls.logContent = " Not enough money, please try another other building.";

			}
		}
		if (ss.stage == 2) 
		{
			if (rm.moneyP2 >= rm.coalMoneyCost && rm.popP2>=rm.coalPopCost)  
			{
				buildingSelection = 3;
				ls.logContent = " Please select an empty space to place the building.";
			} 
			else 
			{
				ls.logContent = " Not enough money, please try another other building.";

			}
		}
	}

	public void OnWindTurbClick()
	{
		if (ss.stage == 1) 
		{
			if (rm.moneyP1 >= rm.windMoneyCost && rm.popP1>=rm.windPopCost) 
			{
				buildingSelection = 4;
				ls.logContent = " Please select an empty space to place the building.";
			} 
			else 
			{
				ls.logContent = " Not enough money, please try another other building.";

			}
		}
		if (ss.stage == 2) 
		{
			if (rm.moneyP2 >= rm.windMoneyCost && rm.popP2>=rm.windPopCost) 
			{
				buildingSelection = 4;
				ls.logContent = " Please select an empty space to place the building.";
			} 
			else 
			{
				ls.logContent = " Not enough money, please try another other building.";

			}
		}
	}

	public void OnOilRigClick()
	{
		if (ss.stage == 1) 
		{
			if (rm.moneyP1 >= rm.oilMoneyCost && rm.popP1>=rm.oilPopCost) 
			{
				buildingSelection = 5;
				ls.logContent = " Please select an empty space to place the building.";
			} 
			else 
			{
				ls.logContent = " Not enough money, please try another other building.";

			}
		}
		if (ss.stage == 2) 
		{
			if (rm.moneyP2 >= rm.oilMoneyCost && rm.popP2>=rm.oilPopCost) 
			{
				buildingSelection = 5;
				ls.logContent = " Please select an empty space to place the building.";
			} 
			else 
			{
				ls.logContent = " Not enough money, please try another other building.";

			}
		}
	}



}
