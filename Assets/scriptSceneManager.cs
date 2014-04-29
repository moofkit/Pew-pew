//Scene Manager Script

using UnityEngine;
using System.Collections;

public class scriptSceneManager : MonoBehaviour {

	//Inspector Variables
	public float gameTime = 10;
	static public int score = 0;
	static public int lives = 3;
	public KeyCode		exitGameKey;
	//Private Variables
	
	// Use this for initialization
	void Start () {
		InvokeRepeating("CountDown", 1, 1);
	}
	
	// Update is called once per frame
	void Update () {
		if(lives <= 0){
			PlayerPrefs.SetInt("SCORE", score);
			Application.LoadLevel("screenLose");
			lives= 3;
			score= 0;
		}
		if(gameTime <=0) {
			PlayerPrefs.SetInt("SCORE", score);
			Application.LoadLevel("screenWin");
			lives = 3;
			score = 0;
		}
		
		if(Input.GetKeyDown(exitGameKey)){
			Application.Quit();	
		}
	}
	
	static public void AddScore (){
		score++;
	}
	
	void OnGUI(){
		GUI.Label(new Rect(10, 10, 100, 20), "Score: " + score);
		GUI.Label(new Rect(10, 25, 100, 35), "Lives: " + lives);
		GUI.Label(new Rect(10, 40, 100, 50), "Shields: " + scriptPlayer.numberOfShields);
		GUI.Label(new Rect(Screen.width -75, 10, 100, 20), "Timer: " + gameTime);
	}
	
	
	//Game Timer
	void CountDown() {
		if (--gameTime == 0) 
		{
			CancelInvoke("CountDown");
		}
	}
	
}
