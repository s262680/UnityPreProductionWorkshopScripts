using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ResourcesManager : MonoBehaviour {

	public float popP1 =1000;
	public float moneyP1 =1000;
	public float popP2 =1000;
	public float moneyP2 =1000;
	//public float water=50;
	//public float heat=50;
	//public float energy=50;
	//public string eleSelect="";
	public bool calcTrigger=false;
	public bool eventTrigger=false;
	public string eventType="";
	public bool onceTrigger=false;

	public float solarPopCost = 200;
	public float solarMoneyCost=500;
	public float gasPopCost = 200;
	public float gasMoneyCost=500;
	public float nulclearPopCost = 600;
	public float nulclearMoneyCost= 1500;
	public float coalPopCost = 300;
	public float coalMoneyCost=300;
	public float windPopCost = 200;
	public float windMoneyCost=400;
	public float oilPopCost= 350;
	public float oilMoneyCost=500;

	public float solarPopRate = 150;
	public float solarMoneyRate=100;
	public float gasPopRate = 50;
	public float gasMoneyRate=100;
	public float nulclearPopRate = 200;
	public float nulclearMoneyRate=400;
	public float coalPopRate = 50;
	public float coalMoneyRate=200;
	public float windPopRate = 100;
	public float windMoneyRate=100;
	public float oilPopRate = 50;
	public float oilMoneyRate=300;

	public float p1PopAffect=0;
	public float p1MoneyAffect=0;
	public float p2PopAffect=0;
	public float p2MoneyAffect=0;
	public float p1PopNegAffect=0;
	public float p2PopNegAffect=0;


	GameObject buildingPanel;
	BuildingScript bp;

	public GameObject[] P1Building;
	public GameObject[] P2Building;

	Text popP1Text;
	Text moneyP1Text;
	Text popP2Text;
	Text moneyP2Text;
	//Text heatText;
	//Text energyText;

	GameObject stage;
	StageScript ss;

	GameObject pOJ;

	// Use this for initialization
	void Start () {

		popP1Text=transform.Find ("popP1").GetComponent<Text>();
		moneyP1Text=transform.Find ("moneyP1").GetComponent<Text>();
		popP2Text=transform.Find ("popP2").GetComponent<Text>();
		moneyP2Text=transform.Find ("moneyP2").GetComponent<Text>();

		stage = GameObject.Find ("Stage");
		ss = stage.GetComponent<StageScript> ();

		popP1Text.color = new Color (0, 0, 1, 1);
		moneyP1Text.color = new Color (0, 0, 1, 1);
		popP2Text.color = new Color (1, 0, 0, 1);
		moneyP2Text.color = new Color (1, 0, 0, 1);


	}
	
	// Update is called once per frame
	void Update () {


		ResourceCost ();
		ResourceUpdate();

	


		popP1Text.text =  ""+popP1;
		moneyP1Text.text =  ""+moneyP1;
		popP2Text.text =  ""+popP2;
		moneyP2Text.text = "" + moneyP2;




	}
		
	//buildings*****************
	void SolarSelected()
	{
		if (ss.stage == 1) 
		{
			popP1 -= solarPopCost;
			moneyP1 -= solarMoneyCost;
		}
		else if (ss.stage == 2) 
		{
			popP2 -= solarPopCost;
			moneyP2 -= solarMoneyCost;
		}
	}

	void GasSelected()
	{
		if (ss.stage == 1) 
		{
			popP1 -= gasPopCost;
			moneyP1 -= gasMoneyCost;
		}
		else if (ss.stage == 2) 
		{
			popP2 -= gasPopCost;
			moneyP2 -= gasMoneyCost;
		}
	}

	void NulclearSelected()
	{
		if (ss.stage == 1) 
		{
			popP1 -= nulclearPopCost;
			moneyP1 -= nulclearMoneyCost;
		}
		else if (ss.stage == 2) 
		{
			popP2 -= nulclearPopCost;
			moneyP2 -= nulclearMoneyCost;
		}
	}

	void CoalMineSelected()
	{
		if (ss.stage == 1) 
		{
			popP1 -= coalPopCost;
			moneyP1 -= coalMoneyCost;
		}
		else if (ss.stage == 2) 
		{
			popP2 -= coalPopCost;
			moneyP2 -= coalMoneyCost;
		}
	}

	void WindTurbSelected()
	{
		if (ss.stage == 1) 
		{
			popP1 -= windPopCost;
			moneyP1 -= windMoneyCost;
		}
		else if (ss.stage == 2) 
		{
			popP2 -= windPopCost;
			moneyP2 -= windMoneyCost;
		}
	}

	void OilRigSelected()
	{
		if (ss.stage == 1) 
		{
			popP1 -= oilPopCost;
			moneyP1 -= oilMoneyCost;
		}
		else if (ss.stage == 2) 
		{
			popP2 -= oilPopCost;
			moneyP2 -= oilMoneyCost;
		}
	}

	public void ResourceCost()
	{
		if (calcTrigger) 
		{
			buildingPanel = GameObject.Find ("BuildingPanel");
			bp = buildingPanel.GetComponent<BuildingScript>();


			if (bp.buildingSelection == 0) 
			{
				SolarSelected ();
			}
			else if (bp.buildingSelection == 1) 
			{
				GasSelected ();
			}
			else if (bp.buildingSelection == 2) 
			{
				NulclearSelected ();
			}
			else if (bp.buildingSelection == 3) 
			{
				CoalMineSelected ();
			}
			else if (bp.buildingSelection == 4) 
			{
				WindTurbSelected ();
			}
			else if (bp.buildingSelection == 5) 
			{
				OilRigSelected ();
			}

			if (ss.stage == 1) 
			{
				ss.stage = 2;
			}
			else if (ss.stage == 2) 
			{
				ss.stage = 3;
				onceTrigger = true;
			}

			bp.buildingSelection = -1;
			calcTrigger = false;

		}

	}

	public void ResourceUpdate()
	{
		if (onceTrigger) 
		{
			P1Building = GameObject.FindGameObjectsWithTag ("P1Building");
			P2Building = GameObject.FindGameObjectsWithTag ("P2Building");

			foreach (GameObject p1B in P1Building)
			{
				pOJ = p1B.transform.parent.gameObject;

				if (pOJ.tag == "SpNode") {
					if (p1B.name == "solar") {
						p1PopAffect += solarPopRate*2;
						p1MoneyAffect += solarMoneyRate*2;
					} else if (p1B.name == "gas") {
						p1PopAffect += gasPopRate*2;
						p1MoneyAffect += gasMoneyRate*2;
					} else if (p1B.name == "nul") {
						p1PopAffect += nulclearPopRate*2;
						p1MoneyAffect += nulclearMoneyRate*2;
					} else if (p1B.name == "coal") {
						p1PopAffect += coalPopRate*2;
						p1MoneyAffect += coalMoneyRate*2;
					} else if (p1B.name == "wind") {
						p1PopAffect += windPopRate*2;
						p1MoneyAffect += windMoneyRate*2;
					} else if (p1B.name == "oil") {
						p1PopAffect += oilPopRate*2;
						p1MoneyAffect += oilMoneyRate*2;
					}
				} 
				else {
					if (p1B.name == "solar") {
						p1PopAffect += solarPopRate;
						p1MoneyAffect += solarMoneyRate;
					} else if (p1B.name == "gas") {
						p1PopAffect += gasPopRate;
						p1MoneyAffect += gasMoneyRate;
					} else if (p1B.name == "nul") {
						p1PopAffect += nulclearPopRate;
						p1MoneyAffect += nulclearMoneyRate;
					} else if (p1B.name == "coal") {
						p1PopAffect += coalPopRate;
						p1MoneyAffect += coalMoneyRate;
					} else if (p1B.name == "wind") {
						p1PopAffect += windPopRate;
						p1MoneyAffect += windMoneyRate;
					} else if (p1B.name == "oil") {
						p1PopAffect += oilPopRate;
						p1MoneyAffect += oilMoneyRate;
					}
				}



			}

			foreach (GameObject p2B in P2Building)
			{
				pOJ = p2B.transform.parent.gameObject;

				if (pOJ.tag == "SpNode") {
					if (p2B.name == "solar") {
						p2PopAffect += solarPopRate*2;
						p2MoneyAffect += solarMoneyRate*2;
					} else if (p2B.name == "gas") {
						p2PopAffect += gasPopRate*2;
						p2MoneyAffect += gasMoneyRate*2;
					} else if (p2B.name == "nul") {
						p2PopAffect += nulclearPopRate*2;
						p2MoneyAffect += nulclearMoneyRate*2;
					} else if (p2B.name == "coal") {
						p2PopAffect += coalPopRate*2;
						p2MoneyAffect += coalMoneyRate*2;
					} else if (p2B.name == "wind") {
						p2PopAffect += windPopRate*2;
						p2MoneyAffect += windMoneyRate*2;
					} else if (p2B.name == "oil") {
						p2PopAffect += oilPopRate*2;
						p2MoneyAffect += oilMoneyRate*2;
					}
				} 
				else {
					if (p2B.name == "solar") {
						p2PopAffect += solarPopRate;
						p2MoneyAffect += solarMoneyRate;
					} else if (p2B.name == "gas") {
						p2PopAffect += gasPopRate;
						p2MoneyAffect += gasMoneyRate;
					} else if (p2B.name == "nul") {
						p2PopAffect += nulclearPopRate;
						p2MoneyAffect += nulclearMoneyRate;
					} else if (p2B.name == "coal") {
						p2PopAffect += coalPopRate;
						p2MoneyAffect += coalMoneyRate;
					} else if (p2B.name == "wind") {
						p2PopAffect += windPopRate;
						p2MoneyAffect += windMoneyRate;
					} else if (p2B.name == "oil") {
						p2PopAffect += oilPopRate;
						p2MoneyAffect += oilMoneyRate;
					}
				}
			}

			popP1 += p1PopAffect;
			moneyP1 += p1MoneyAffect;
			popP2 += p2PopAffect;
			moneyP2 += p2MoneyAffect;

			popP1 -= p1PopNegAffect;
			popP2 -= p2PopNegAffect;

			onceTrigger = false;
		}

	}




	//events****************************
	void WaterFlood()
	{
		
	}
	void OverHeat()
	{
		

	}
	void PowerPlantFailed()
	{
		
	}

}
