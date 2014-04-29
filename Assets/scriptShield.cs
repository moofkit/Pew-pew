//Shield Script

using UnityEngine;
using System.Collections;

public class scriptShield : MonoBehaviour {

	//Inspector Variables
	public int shieldStrenght = 1;
	
	
	void OnTriggerEnter ( Collider other) {
		if (other.tag == "astroid"){
			shieldStrenght--;
		}
	}
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(shieldStrenght<=0){
			Destroy(gameObject);
			scriptPlayer.shieldOn = false;
		}
	}
}
