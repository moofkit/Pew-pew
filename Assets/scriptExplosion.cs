using UnityEngine;
using System.Collections;

public class scriptExplosion : MonoBehaviour {
	
	//Inspector Variables
	public float explosionSpeed = 7.0f;
	
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.down * explosionSpeed * Time.deltaTime, Space.World);
	}
}
