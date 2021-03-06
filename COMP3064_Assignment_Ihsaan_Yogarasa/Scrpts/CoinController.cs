﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Ihsaan Yogarasa
 * CoinController
 * LastUpdated 2017-10-19
 *
 */ 

public class CoinController : MonoBehaviour {


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
	// Use this for initialization
	void Start () {

		_transform = gameObject.GetComponent<Transform> ();
		Reset ();

	}
	//Resets coin location + speed
	public void Reset(){

		float xSpeed = Random.Range (minXSpeed, maxXSpeed);
		float ySpeed = Random.Range (minYSpeed, maxYSpeed);

		_currentSpeed = new Vector2 (xSpeed, ySpeed);

		float x = Random.Range (23,30);
		_transform.position = new Vector2 (x, 20 + Random.Range(0,50));

	}

	// Resets coin location
	void Update () {
		_currentPosition = _transform.position;
		_currentPosition -= _currentSpeed;
		_transform.position = _currentPosition;

		if (_currentPosition.y <= -58) {
			Reset ();

		}

	}
}
