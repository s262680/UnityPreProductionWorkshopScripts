using UnityEngine;
using System.Collections;

public class SpawnPointHealthScript : MonoBehaviour {
	
	GameObject stage;
	StageScript ss;
	GameObject resources;
	ResourcesManager rm;

	GameObject childOj;
	public float health=100;

	bool onceTrigger=false;

	public float solarDmg = 0;
	public float gasDmg = 25;
	public float nuDmg = 0;
	public float coalDmg = 30;
	public float windDmg = 0;
	public float oilDmg = 30;


	// Use this for initialization
	void Start () {
		stage = GameObject.Find ("Stage");
		ss = stage.GetComponent<StageScript> ();
		resources = GameObject.Find ("Resources");
		rm = resources.GetComponent<ResourcesManager> ();
	}

	// Update is called once per frame
	void Update () {

		if (ss.stage != 3) 
		{
			onceTrigger = true;
		}
			
	
	
		if (ss.stage == 3)
		{
			if (onceTrigger)
			{
				if (transform.childCount > 0)
				{
					childOj = this.gameObject.transform.GetChild (0).gameObject;
				
					if (childOj.name == "solar") 
					{
						health -= solarDmg;					
					}
					else if (childOj.name == "gas") 
					{
						health -= gasDmg;					
					}
					else if (childOj.name == "nul") 
					{
						health -= nuDmg;					
					}
					else if (childOj.name == "coal") 
					{
						health -= coalDmg;					
					}
					else if (childOj.name == "wind") 
					{
						health -= windDmg;					
					}
					else if (childOj.name == "oil") 
					{
						health -= oilDmg;					
					}

					onceTrigger = false;
				}
			}

			if (health <= 0) 
			{
				if (transform.childCount > 0) 
				{
					childOj = this.gameObject.transform.GetChild (0).gameObject;
					if (childOj.tag == "P1Building") 
					{
						rm.p1PopNegAffect += 300;
					}
					else if (childOj.tag == "P2Building") 
					{
						rm.p2PopNegAffect += 300;
					}
				}
				Destroy (this.gameObject); 
			}
		}




	}



}
