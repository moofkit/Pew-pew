//Bullet Script
using UnityEngine;
using System.Collections;

public class scriptBullet : MonoBehaviour {
	//Inspector Variables
	public float bulletSpeed = 15.0f;		//Speed of the bullet
	public float heightLimit = 10.0f;		//The range the bullet can travel
	public Transform explosion;
	public AudioClip explosionSound;
	//Private Variables
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	transform.Translate(Vector3.up * bulletSpeed * Time.deltaTime);
		
	if(transform.position.y >= heightLimit) {
			Destroy(gameObject);
		}
	}
	
	void OnTriggerEnter (Collider other){
		if(other.gameObject.tag == "astroid"){
			//other.transform.position = new Vector3(Random.Range(-6.0f, 6.0f), 11.0f, other.transform.position.z);
			scriptAstroid otherScript;
			otherScript = other.GetComponent<scriptAstroid>();
			otherScript.ResetPosition();
			
			//Create the explosion on impact
			if(explosion){
				Instantiate(explosion, transform.position, transform.rotation);
				if (explosionSound){
					AudioSource.PlayClipAtPoint(explosionSound, new Vector3(0, 0, 0));
				}
			}
			
			//Tell score manager that we destroyed an enemy and add a point to the score
			scriptSceneManager.AddScore();
			
			//Get rid of the bullet
			Destroy(gameObject);
		}
	}
}
