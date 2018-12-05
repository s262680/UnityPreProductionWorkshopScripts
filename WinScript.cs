using UnityEngine;
using System.Collections;

public class WinScript : MonoBehaviour {

	public GameObject p1text;
	public GameObject p2text;
	public GameObject loseText;
	public GameObject mainCanvas;
	public GameObject endCanvas;
	bool p1win;
	bool p2win;
	bool lose;
	public ResourcesManager rm;

	// Use this for initialization
	void Start () 
	{
		p1win = false;
		p2win = false;
		lose = false;
		p1text.SetActive(false);
		p2text.SetActive(false);
		loseText.SetActive(false);
		endCanvas.SetActive(false);
		mainCanvas.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (p1win == true || p2win == true || lose == true)
		{
			mainCanvas.SetActive(false);
			endCanvas.SetActive(true);
		}
		if (rm.popP1 >= 3000)
		{
			p1win = true;
		}

		if (p1win == true)
		{
			p1text.SetActive(true);
		}

		if (rm.moneyP2 >= 3000)
		{
			p2win = true;
		}

		if (p2win == true)
		{
			p2text.SetActive(true);
		}

		if (lose == true)
		{
			loseText.SetActive(true);
		}
	}

	public void PlayAgain()
	{
		Application.LoadLevel("MenuScene");
	}

    public void QuitGame()
    {
        Application.Quit();
    }
}
