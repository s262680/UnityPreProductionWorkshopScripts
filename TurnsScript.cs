using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TurnsScript : MonoBehaviour {

	Text turnText;
	public Text playerTurnText;

	public int turns;
	public string playerTurn;
	//GameObject turnTextOj;


	// Use this for initialization
	void Start () {

		turns = 1;
		playerTurn= "";
		turnText=transform.Find ("TurnText").GetComponent<Text>();
		playerTurnText=transform.Find ("PlayerTurnText").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		turnText.text = "Turn " + turns;
		playerTurnText.text = playerTurn;
	}
}
