using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Ihsaan Yogarasa
 * BuffController
 * LastUpdated 2017-10-19
 *
 */ 

public class BuffController : MonoBehaviour {
	

	[SerializeField]
	float minYSpeed =0.1f;
	[SerializeField]
	float maxYSpeed =0.1f;
	[SerializeField]
	float minXSpeed =0.1f;
	[SerializeField]
	float maxXSpeed =0.1f;

	private Transform _transform;
	private Vector2 _currentSpeed;
	private Vector2 _currentPosition;
	private AudioSource _BuffsAudio;
	// Use this for initialization
	void Start () {

		_transform = gameObject.GetComponent<Transform> ();
		Reset ();
		_BuffsAudio = gameObject.GetComponent<AudioSource> ();
	
	}
	//Resets the buff and the speed of the rate the buff is falling
	public void Reset(){

		float xSpeed = Random.Range (minXSpeed, maxXSpeed);
		float ySpeed = Random.Range (minYSpeed, maxYSpeed);

		_currentSpeed = new Vector2 (xSpeed, ySpeed);

		float x = Random.Range (15,20);
		_transform.position = new Vector2 (x, 20 + Random.Range(0,50));

	}

	// Resets buff back to drop again
	void Update () {
		_currentPosition = _transform.position;
		_currentPosition -= _currentSpeed;
		_transform.position = _currentPosition;

		if (_currentPosition.y <= -58) {
			Reset ();

		}
	}

	}




