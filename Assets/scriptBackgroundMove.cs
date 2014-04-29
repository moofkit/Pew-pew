using UnityEngine;
using System.Collections;

public class scriptBackgroundMove : MonoBehaviour {
	
	//Public
	public float speed = 6.0f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.forward * speed * Time.deltaTime * -1);
	}
}
