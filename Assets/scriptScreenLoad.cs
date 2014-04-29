using UnityEngine;
using System.Collections;

public class scriptScreenLoad : MonoBehaviour {
	
	//Inspector Variable
	public float waitTime = 5.0f;
	
	void OnGUI(){
		//Make a group on the center of the screen
		GUI.BeginGroup (new Rect(Screen.width / 2 -100, Screen.height / 2 -100, 200, 200));
		
		//Make a box to see the group on screen
		GUI.Box(new Rect(0, 0, 200, 200), "Instructions");
		
		//Instructions for the player
		GUI.Label(new Rect(10, 30, 140, 40), "Arrow Keys to Move");
		GUI.Label(new Rect(10, 60, 160, 70), "Spacebar to Shoot");
		GUI.Label(new Rect(10, 90, 160, 100), "E to use the Shield");
		GUI.Label(new Rect(10, 120, 160, 100), "Esc to Quit the Game");
		
		
		GUI.EndGroup();
	}
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.anyKeyDown) {
			Application.LoadLevel("Scene01");
		}
		else {
			StartCoroutine(WaitTime());
		}
		
	}
	
	IEnumerator WaitTime(){
		yield return new WaitForSeconds(waitTime);
		Application.LoadLevel("Scene01");
	}
}
