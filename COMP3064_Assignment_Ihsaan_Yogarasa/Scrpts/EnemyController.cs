using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*Ihsaan Yogarasa
 * EnemyController
 * LastUpdated 2017-10-19
 *
 */ 

public class EnemyController : MonoBehaviour {

	[SerializeField]
	float minYSpeed =5f;
	[SerializeField]
	float maxYSpeed =5f;
	[SerializeField]
	float minXSpeed =5f;
	[SerializeField]
	float maxXSpeed =5f;

	private Transform _transform;
	private Vector2 _currentSpeed;
	private Vector2 _currentPosition;
	// Use this for initialization
	void Start () {

		_transform = gameObject.GetComponent<Transform> ();
		Reset ();

	}
	 // Reset + different enemy positioning
	public void Reset(){

		float xSpeed = Random.Range (minXSpeed, maxXSpeed);
		float ySpeed = Random.Range (minYSpeed, maxYSpeed);

		_currentSpeed = new Vector2 (xSpeed, ySpeed);

		float x = Random.Range (19,20);
		_transform.position = new Vector2 (x, 20  + Random.Range(0,50));

	}
	
	// Updates the enemy controller as they go off frame
	void Update () {
		_currentPosition = _transform.position;
		_currentPosition -= _currentSpeed;
		_transform.position = _currentPosition;

		if (_currentPosition.y <= -58) {
			Reset ();
		
		}

	}
}
