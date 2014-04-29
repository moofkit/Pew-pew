//Credit Script

using UnityEngine;
using System.Collections;

public class scriptScreenCredit : MonoBehaviour {
	
	//Inspector Variebles
	public float h = 40.0f;
	public float w = 250.0f;
	
	void OnGUI(){
		//Make a group on the center of the screen
		GUI.BeginGroup (new Rect(Screen.width / 2 -100, Screen.height / 2 -100, 300, 300));
		
		//Make a box to see the group on screen
		GUI.Box(new Rect(0, 0, 200, 210), "Credits");
		
		//Instructions for the player
		GUI.Label(new Rect(10, 30, 250, 40), 	"Software			Ivliev Dmitriy");
		GUI.Label(new Rect(10, 60, 255, 70), 	"Artist				   Oleg Tsitovich");
		
		//Add Button here
		
		if( GUI.Button(new Rect(60, 165, 80, 30), "Back") ){
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
