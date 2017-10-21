using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*Ihsaan Yogarasa
 * BackgroundController
 * LastUpdated 2017-10-19
 *
 */ 

public class BackgroundController : MonoBehaviour {

	//slow speed for moving background
	float speed = 0.5f;

	private Transform _transform = null;
	private Vector2 _currentPosition ;

	//Constants
	private const float startPos = 0f;
	private const float resetPos = -39f;

	// initialization
	void Start () {

		_transform = gameObject.transform;
		_currentPosition = _transform.position;

		//Reset the position
		Reset ();
	}

	// Update method in moving the background
	void Update () {

		// scrolling backgriund
		_currentPosition = _transform.position;
		_currentPosition -= new Vector2(speed, 0);
		_transform.position = _currentPosition;

		if (gameObject.transform.position.x < resetPos)
			Reset ();
	}

	//Reset backgorund
	public void Reset(){


		_currentPosition = new Vector2(startPos, 0);
		_transform.position = _currentPosition;


	}


}