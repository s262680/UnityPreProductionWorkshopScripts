using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TooltipScript : MonoBehaviour{

	int tooltipToDisplay;
	GameObject resources;
	ResourcesManager rm;
	GameObject stageScript;
	StageScript ss;
	Text solarText;
	Text gasText;
	Text nuclearText;
	Text coalText;
	Text windText;
	Text oilText;
	GameObject SPHealthOJ;
	SpawnPointHealthScript sh;

	// Use this for initialization
	void Start () {

		resources = GameObject.Find ("Resources");
		rm = resources.GetComponent<ResourcesManager> ();
		stageScript = GameObject.Find ("Stage");
		ss = stageScript.GetComponent<StageScript> ();
		SPHealthOJ = GameObject.Find ("SpawnPointFab");
		sh = SPHealthOJ.GetComponent<SpawnPointHealthScript> ();


		gasText = transform.Find ("GasTip").GetComponent<Text>();
		nuclearText = transform.Find ("NuclearTip").GetComponent<Text>();
		coalText = transform.Find ("CoalTip").GetComponent<Text>();
		windText = transform.Find ("WindTip").GetComponent<Text>();
		oilText = transform.Find ("OilTip").GetComponent<Text>();
		solarText = transform.Find ("SolarTip").GetComponent<Text>();

	}

	// Update is called once per frame
	void Update () 
	{
		tooltipToDisplay = ss.stage;
	}

	public void SolarTip ()
	{
		if (tooltipToDisplay == 1)
		{
			solarText.text = "Requires " + rm.solarPopCost + " population and $" + rm.solarMoneyCost + " to build. \n Generates "
				+ rm.solarPopRate + " population per turn." + " Building does "+sh.solarDmg+" damage to the land";
		}

		if (tooltipToDisplay == 2)
		{
			solarText.text = "Requires " + rm.solarPopCost + " population and $" + rm.solarMoneyCost + " to build. \n Generates $"
				+ rm.solarMoneyRate + " per turn.";
		}
	}

	public void GasTip ()
	{
		if (tooltipToDisplay == 1)
		{
			gasText.text = "Requires " + rm.gasPopCost + " population and $" + rm.gasMoneyCost + " to build. \n Generates "
				+ rm.gasPopRate + " population per turn."+ " Building does "+sh.gasDmg+" damage to the land";
		}

		if (tooltipToDisplay == 2)
		{
			gasText.text = "Requires " + rm.gasPopCost + " population and $" + rm.gasMoneyCost + " to build. \n Generates $"
				+ rm.gasMoneyRate + " per turn.";
		}
	}

	public void NuclearTip ()
	{
		if (tooltipToDisplay == 1)
		{
			nuclearText.text = "Requires " + rm.nulclearPopCost + " population and $" + rm.nulclearMoneyCost + " to build. \n Generates "
				+ rm.nulclearPopRate + " population per turn."+ " Building does "+sh.nuDmg+" damage to the land";
		}

		if (tooltipToDisplay == 2)
		{
			nuclearText.text = "Requires " + rm.nulclearPopCost + " population and $" + rm.nulclearMoneyCost + " to build. \n Generates $"
				+ rm.nulclearMoneyRate + " per turn.";
		}
	}

	public void CoalTip ()
	{
		if (tooltipToDisplay == 1)
		{
			coalText.text = "Requires " + rm.coalPopCost + " population and $" + rm.coalMoneyCost + " to build. \n Generates "
				+ rm.coalPopRate + " population per turn."+ " Building does "+sh.coalDmg+" damage to the land";
		}

		if (tooltipToDisplay == 2)
		{
			coalText.text = "Requires " + rm.coalPopCost + " population and $" + rm.coalMoneyCost + " to build. \n Generates $"
				+ rm.coalMoneyRate + " per turn.";
		}
	}

	public void WindTip ()
	{
		if (tooltipToDisplay == 1)
		{
			windText.text = "Requires " + rm.windPopCost + " population and $" + rm.windMoneyCost + " to build. \n Generates "
				+ rm.windPopRate + " population per turn."+ " Building does "+sh.windDmg+" damage to the land";
		}

		if (tooltipToDisplay == 2)
		{
			windText.text = "Requires " + rm.windPopCost + " population and $" + rm.windMoneyCost + " to build. \n Generates $"
				+ rm.windMoneyRate + " per turn.";
		}
	}

	public void OilTip ()
	{
		if (tooltipToDisplay == 1)
		{
			oilText.text = "Requires " + rm.oilPopCost + " population and $" + rm.oilMoneyCost + " to build. \n Generates "
				+ rm.oilPopRate + " population per turn."+ " Building does "+sh.oilDmg+" damage to the land";
		}

		if (tooltipToDisplay == 2)
		{
			oilText.text = "Requires " + rm.oilPopCost + " population and $" + rm.oilMoneyCost + " to build. \n Generates $"
				+ rm.oilMoneyRate + " per turn.";
		}
	}
}
