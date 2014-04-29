//Lose Script

using UnityEngine;
using System.Collections;

public class scriptScreenLose : MonoBehaviour {
	
	//Inspector Variable
	public string loseQuote = "You Lose!";
	
	
	void OnGUI(){
		//Make a group on the center of the screen
		GUI.BeginGroup (new Rect(Screen.width / 2 -100, Screen.height / 2 -100, 200, 100));
		
		//Make a box to see the group on screen
		GUI.Box(new Rect(0, 0, 200, 100), loseQuote);
		
		//Instructions for the player
		GUI.Label(new Rect(10, 30, 200, 50), 	"Score: " + PlayerPrefs.GetInt("SCORE"));
		
		//Add Button here
		
		if( GUI.Button(new Rect(60, 60, 80, 30), "Main Menu") ){
			Application.LoadLevel("screenMainMenu");
		}
		
		GUI.EndGroup();
	}
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
