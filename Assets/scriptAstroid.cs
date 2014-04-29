//Player Script

using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class scriptAstroid : MonoBehaviour {
	
	//Inspector Variables
	public float astroidSpeedMax = 6.0f;
	public float astroidSpeedMin = 4.0f;
	public float rotationSpeed = 50.0f;
	public Transform explosion;
	public AudioClip healthHurtSound;   																														//sound of hurting
	public AudioClip explosionSound;
	
	//Private Variables
	float scaleAstroid;
	float astroidSpeed;

	// Use this for initialization
	void Start () {
		/*transform.localRotation = Quaternion.AngleAxis(Random.Range(0, 100.0f), Vector3.up);
		transform.localRotation = Quaternion.AngleAxis(Random.Range(0, 200.0f), Vector3.left);
		transform.localRotation = Quaternion.AngleAxis(Random.Range(0, 300.0f), Vector3.forward);*/
		ResetPosition();
	}
	
	// Update is called once per frame
	void Update () {
		float rotationX = rotationSpeed * Time.deltaTime;
		transform.Translate(Vector3.down * astroidSpeed * Time.deltaTime, Space.World); 
		transform.localRotation *= Quaternion.AngleAxis(rotationX, Vector3.up);
		transform.localRotation *= Quaternion.AngleAxis(rotationX, Vector3.left);
		transform.localRotation *= Quaternion.AngleAxis(rotationX, Vector3.forward);
		
		//Check for the bottom of screen
		if(transform.position.y <= -7.0f) {
			ResetPosition();
		}
	}
	
	void OnTriggerEnter (Collider other){
		if(other.gameObject.tag == "Player"){
			scriptSceneManager.lives--;
			audio.clip = healthHurtSound;
			audio.Play();
			/*scriptPlayer playerScript;
			playerScript = other.GetComponent<scriptPlayer>();
			playerScript.lives -= 1;*/
			if(explosion){
				Instantiate(explosion, transform.position, transform.rotation);
			}
			
			ResetPosition();
		}
		
		if(other.gameObject.tag == "Shield"){
			if(explosion){
				Instantiate(explosion, transform.position, transform.rotation);
				audio.clip = explosionSound;
				audio.Play();
			}
			ResetPosition();
		}
	}
	
	public void ResetPosition(){
		//Reset the position of the enemy
		transform.position = new Vector3(Random.Range(-10.0f, 10.0f), 12.0f, transform.position.z);
		transform.localRotation = Random.rotation;
		scaleAstroid = Random.Range(0.7f, 1.2f);
		transform.localScale = new Vector3(scaleAstroid, scaleAstroid, scaleAstroid);
		float randomRotateSpeedFactor;
		do {
			randomRotateSpeedFactor = Random.Range(-1, 1);
		} while (randomRotateSpeedFactor == 0);
		rotationSpeed *= Random.Range(0.8f, 1.3f) * randomRotateSpeedFactor;
		astroidSpeed = Random.Range(astroidSpeedMin, astroidSpeedMax);
	}
}
