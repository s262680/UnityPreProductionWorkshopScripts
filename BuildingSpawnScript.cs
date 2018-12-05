using UnityEngine;
using System.Collections;

public class BuildingSpawnScript : MonoBehaviour {


	GameObject buildingPanel;
	BuildingScript bp;
	GameObject resources;
	ResourcesManager rm;
	GameObject logPanel;
	LogScript ls;
	GameObject stage;
	StageScript ss;

	bool spawnTrigger=false;

	public GameObject[] P1Building;
	public GameObject[] P2Building;

	public GameObject[] buildFab; 


	// Use this for initialization
	void Start () {
		logPanel = GameObject.Find ("LogPanel");
		ls = logPanel.GetComponent<LogScript> ();
		stage = GameObject.Find ("Stage");
		ss = stage.GetComponent<StageScript> ();




	}

	// Update is called once per frame
	void Update () {


		P1Building = GameObject.FindGameObjectsWithTag ("P1Building");
		P2Building = GameObject.FindGameObjectsWithTag ("P2Building");

		
		if (Input.GetButtonDown ("Fire1")) 
		{
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit)) 
			{				
				if (hit.collider.gameObject == this.gameObject) 
				{
					if (ss.stage == 1) 
					{
						foreach (GameObject nb in P1Building)
						{
							if ((this.transform.position - nb.transform.position).sqrMagnitude < 0.02) 
							{
								//Debug.Log ((this.transform.position - nb.transform.position).sqrMagnitude);
								spawnTrigger = true;
							}
						}
					}
					else if (ss.stage == 2) 
					{
						foreach (GameObject nb in P2Building)
						{
							if ((this.transform.position - nb.transform.position).sqrMagnitude < 0.02) 
							{
								spawnTrigger = true;
							}
						}
					}

					if (spawnTrigger)
					{
						SpawnBuilding ();
						spawnTrigger = false;
					}
				}
			}
		}
	}

	void SpawnBuilding()
	{
		buildingPanel = GameObject.Find ("BuildingPanel");
		bp = buildingPanel.GetComponent<BuildingScript>();
		resources = GameObject.Find ("Resources");
		rm = resources.GetComponent<ResourcesManager> ();

		GameObject building = (GameObject)Instantiate (buildFab[bp.buildingSelection], transform.position, transform.rotation);
		if (ss.stage == 1) 
		{
			building.tag = "P1Building";
		}
		else if (ss.stage == 2) 
		{
			building.tag = "P2Building";
		}

		if (bp.buildingSelection == 0)
		{
			building.name = "solar";
		}
		else if (bp.buildingSelection == 1)
		{
			building.name = "gas";

		}
		else if (bp.buildingSelection == 2)
		{
			building.name = "nul";

		}
		else if (bp.buildingSelection == 3)
		{
			building.name = "coal";

		}
		else if (bp.buildingSelection == 4)
		{
			building.name = "wind";

		}
		else if (bp.buildingSelection == 5)
		{
			building.name = "oil";

		}
		building.transform.parent = transform;
		building.transform.localPosition += new Vector3 (0, 1.5f, 0);

		rm.calcTrigger = true;
		ls.logContent = "";
	}
}
