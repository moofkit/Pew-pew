//Main Menu Script

using UnityEngine;
using System.Collections;

public class scriptScreenMainMenu : MonoBehaviour {
	
	
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI(){
		//Make a group on the center of the screen
		GUI.BeginGroup (new Rect(Screen.width / 2 -50, Screen.height / 2 -75, 100, 175));
		
		//Make a box to see the group on screen
		GUI.Box(new Rect(0, 0, 100, 175), "Main Menu");
		
		//Add buttons for game navigation
		if( GUI.Button(new Rect(10, 30, 80, 30), "Start Game!") ){
			Application.LoadLevel("screenLoad");
		}
		
		//Add buttons for game navigation
		if( GUI.Button(new Rect(10, 65, 80, 30), "Credits") ){
			Application.LoadLevel("screenCredit");
		}
		
		//Add buttons for game navigation
		if( GUI.Button(new Rect(10, 100, 80, 30), "Homepage") ){
			Application.OpenURL("http://moofkit.comlu.com/");
		}
		
		if( GUI.Button(new Rect(10, 135, 80, 30), "Exit") ){
			Application.Quit();
		}
		
		GUI.EndGroup();
	}
}
