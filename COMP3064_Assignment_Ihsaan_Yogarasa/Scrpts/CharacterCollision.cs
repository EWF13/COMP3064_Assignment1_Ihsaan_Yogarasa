using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*Ihsaan Yogarasa
 * CharacterCollision
 * LastUpdated 2017-10-19
 *
 */ 

public class CharacterCollision : MonoBehaviour {

	[SerializeField]
	GameController gameController;

	// adding the audio source for each enemy, points and buffs
	private AudioSource Gems_Single_06, BladeBuff,GettingHit,GreenCoin;

	// Use this for initialization
	void Start () {
		AudioSource[] audio = GetComponents<AudioSource>();
		Gems_Single_06 = audio [1];
		BladeBuff = audio [2];
		GettingHit = audio [3];
		GreenCoin = audio [0];


	}
	
	// Update is called once per frame
	void Update () {


	}
	//Trigger effect once in contact with player
	public void OnTriggerEnter2D(Collider2D other){

		if (other.gameObject.tag.Equals ("Enemy")) {
			Debug.Log ("Collision Enemy\n");
			if (GettingHit != null) {
				GettingHit.Play ();
			}
			other.gameObject.GetComponent<EnemyController> ().Reset ();

			gameController.Life -= 1;


		}else if
			(other.gameObject.tag.Equals ("Points")){
			Debug.Log ("Points Earned\n");
			if (Gems_Single_06 != null) {
				Gems_Single_06.Play();
			}
			other.gameObject.GetComponent<CoinController>().Reset();
			gameController.Score += 5;


		}else if 
			(other.gameObject.tag.Equals ("ExtraPoints")){
			Debug.Log ("20 Points Earned\n");
			if (GreenCoin != null) {
				GreenCoin.Play();
			}
			other.gameObject.GetComponent<ExtraPointsController>().Reset();
			gameController.Score += 20;

		}else if 
			(other.gameObject.tag.Equals ("Buffs")){
			Debug.Log ("Buff gained\n");
			if (BladeBuff != null) {
				BladeBuff.Play ();
			}
			other.gameObject.GetComponent<BuffController>().Reset();
			gameController.Life += 1;
		}

	}
}

