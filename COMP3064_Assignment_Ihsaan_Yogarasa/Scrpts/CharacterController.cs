using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Ihsaan Yogarasa
 * CharacterController
 * LastUpdated 2017-10-19
 *
 */ 

public class CharacterController : MonoBehaviour {

 // Creating the speed, and control Variables

	public float speed;

	public float leftX;

	public float rightX;

	public float UpY;

	public float DownY;
	private Transform _transform;
	private Vector2 _currentPos;

	//  initialization
	void Start () {

		_transform = gameObject.GetComponent<Transform> ();
		_currentPos = _transform.position; 


	}
	
	// Coding for Playing movement 
	void Update ()
	{
		if (Input.GetKey (KeyCode.A)) {

			_currentPos -= new Vector2 (speed, 0);
		}
	
		if (Input.GetKey (KeyCode.D)){

			_currentPos += new Vector2 (speed, 0);
	}
		if (Input.GetKey (KeyCode.W)) {

			_currentPos += new Vector2 (0, speed);
		}

		if (Input.GetKey (KeyCode.S)) {

			_currentPos -= new Vector2 (0, speed);
		}
		if (Input.GetKey (KeyCode.Space)) {
			_currentPos += new Vector2 (1, speed); 		
		}
	
		Checkbounds (); 
		_transform.position = _currentPos;
}
	// Coding for Insuring the player stays within the boundarys
	private void Checkbounds(){

		if (_currentPos.x < leftX) {
			_currentPos.x = leftX;
		
		}

		if (_currentPos.x > rightX) {
			_currentPos.x = rightX;

		}

		if (_currentPos.y > UpY) {
			_currentPos.y = UpY;
		}
		if (_currentPos.y < DownY) {
			_currentPos.y = DownY;
		}
	}


	}
