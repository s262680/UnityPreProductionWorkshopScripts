using UnityEngine;
using System.Collections;

public class SPColorDifferenceScript : MonoBehaviour {

	public GameObject[] P1Building;
	public GameObject[] P2Building;

	GameObject temp;

	SpawnPointHealthScript sphs;

	//float colourValue=1;
	float colourHealthValue=0;


	// Use this for initialization
	void Start () {
		


	}
	
	// Update is called once per frame
	void Update () {

			P1Building = GameObject.FindGameObjectsWithTag ("P1Building");
			P2Building = GameObject.FindGameObjectsWithTag ("P2Building");

			foreach (GameObject p1B in P1Building)
			{
				if (p1B.transform.childCount>0) 
				{
					temp = p1B.transform.parent.gameObject;
					sphs = temp.GetComponent<SpawnPointHealthScript> ();
					colourHealthValue = (sphs.health / 100);
					//Debug.Log (colourHealthValue);
					Renderer rend = temp.GetComponent<Renderer> ();
					rend.material.shader = Shader.Find ("Transparent/Diffuse");
					rend.material.color = new Color (0, 0, 1, colourHealthValue);

				}
			}

			foreach (GameObject p2B in P2Building) 
			{
				if (p2B.transform.childCount>0) 
				{
					temp = p2B.transform.parent.gameObject;
					sphs = temp.GetComponent<SpawnPointHealthScript> ();
					colourHealthValue = (sphs.health / 100);
					Renderer rend = temp.GetComponent<Renderer> ();
					rend.material.shader = Shader.Find ("Transparent/Diffuse");
					rend.material.color = new Color (1, 0, 0, colourHealthValue);
				}
			}
		}



}
