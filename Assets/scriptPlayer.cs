//Player Script
using UnityEngine;
using System.Collections;

public class scriptPlayer : MonoBehaviour {
	//Inspector Variables
	public float 		playerSpeedVertical 	= 10.0f;																									//speed of the player along the vertical axis
	public float 		playerSpeedHorizontal 	= 10.0f;																									//speed of the player along the horizontal axis
	public float 		horMin 					= -6.0f;																									//limits for player left
	public float 		horMax 					= 6.0f;																										//limits for player right
	public float 		verMin 					= -4.0f;																									//limits for player down
	public float 		verMax 					= 4.0f;																										//limits for player up
	public Transform 	projectile;
	public Transform 	socketProjectile;
	public static int 	numberOfShields 		= 4;
	public Transform	shieldMesh;																															//Load shield Mesh
	public KeyCode		shieldKeyInput;
	public static bool 	shieldOn = false;																													//STATIC! false by default. dont touch it
	//Private Variables
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Store Input Variables
		float transV = Input.GetAxis("Vertical") * playerSpeedVertical * Time.deltaTime;															//use to store varible for vertical movement
		float transH = Input.GetAxis("Horizontal") * playerSpeedHorizontal * Time.deltaTime;														//use to store varible for horizontal movement
		
		//Move player based on Input
		transform.Translate(transH, transV, 0.0f);																									//Here we use the x to move left and right and y to move up and down
		
		//Create a limits for the player in the world
		transform.position = new Vector3(Mathf.Clamp(transform.position.x, horMin, horMax), Mathf.Clamp(transform.position.y, verMin, verMax), 0);
		
		//Create a bullet
		if(Input.GetKeyDown("space")) {
			Instantiate(projectile, socketProjectile.position, socketProjectile.rotation);
			audio.Play();
		}
		
		//Create a shield
		if (Input.GetKeyDown(shieldKeyInput) && !shieldOn && numberOfShields > 0){
			Transform clone = (Transform) Instantiate(shieldMesh, transform.position, transform.rotation);
			clone.transform.parent = gameObject.transform;
			shieldOn = true;
			numberOfShields--;
		}
		
		/*if(transform.position.x >= 6.0f)
			transform.position = new Vector3(6.0f, transform.position.y, transform.position.z);
		if(transform.position.x <= -6.0f)
			transform.position = new Vector3(-6.0f, transform.position.y, transform.position.z);
		
		if(transform.position.y >= 4.0f)
			transform.position = new Vector3(transform.position.x, 4.0f, transform.position.z);
		if(transform.position.y <= -4.0f)
			transform.position = new Vector3(transform.position.x, -4.0f, transform.position.z);*/
		
	}
}
