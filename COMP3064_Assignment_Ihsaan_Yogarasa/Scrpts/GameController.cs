using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

/*Ihsaan Yogarasa
 * GameController
 * LastUpdated 2017-10-19
 *
 */ 

public class GameController : MonoBehaviour {

	[SerializeField]
	Text lifeLabel;
	[SerializeField]
	Text scoreLabel;
	[SerializeField]
	Text gameOverLabel;
	[SerializeField]
	Text endScore;
	[SerializeField]
	Button resetBtn;
	[SerializeField]
	Image GameOverImage;
	[SerializeField]
	Text Controlpage;
	[SerializeField]
	Text Slained;
	[SerializeField]
	Text ReplayText;
	[SerializeField]
	Image NinjaImage;
	[SerializeField]
	Image NinjaHead;

	//Initializing the scores and lives
	private int _score = 0;
	private int _life = 3;

	public int  Score {
		get{ return _score; }
		set {
			_score = value;
			scoreLabel.text = "Score:" +_score;
		}
	}

	public int Life {
		get{ return _life; }
		set {
			_life = value;
			//Update UI

			if (_life <= 0) {
				//game Over
				gameOver();
			} else {
				//Update UI
				lifeLabel.text ="Life:" + _life;
			}
		}
	}

	//Initializing the gameplay screen
	private void initialize() { 
		

		Score = 0;
		Life = 3;


		NinjaHead.gameObject.SetActive (false);
		NinjaImage.gameObject.SetActive (false);
		ReplayText.gameObject.SetActive (false);
		Slained.gameObject.SetActive (false);
		Controlpage.gameObject.SetActive (false);
		gameOverLabel.gameObject.SetActive (false);	
		endScore.gameObject.SetActive (false);
		resetBtn.gameObject.SetActive (false);
		lifeLabel.gameObject.SetActive (true);
		scoreLabel.gameObject.SetActive (true);
		GameOverImage.gameObject.SetActive (false);
		//“How can I freeze the scene while watching a gui window ?” How can I freeze the scene while watching a gui window
		//? - Unity Answers, answers.unity3d.com/questions/124328/how-can-i-freeze-the-scene-while-watching-a-gui-wi.html.
		//This is where I found the code below
			Time.timeScale = 1;
	


	}

	// Game over tab
	private void gameOver(){
	    
		NinjaHead.gameObject.SetActive (true);
		NinjaImage.gameObject.SetActive (false);
		ReplayText.gameObject.SetActive (true);
		Slained.gameObject.SetActive (true);
		Controlpage.gameObject.SetActive (false);
		gameOverLabel.gameObject.SetActive (false);	
		endScore.gameObject.SetActive (true);
		resetBtn.gameObject.SetActive (true);
		lifeLabel.gameObject.SetActive (false);
		scoreLabel.gameObject.SetActive (false);
		GameOverImage.gameObject.SetActive (true);
		endScore.text = scoreLabel.text;
		Time.timeScale = 0;





	}
	//Menu, text and button that appears on start screen
	private void StartGame(){

		NinjaHead.gameObject.SetActive (false);
		NinjaImage.gameObject.SetActive (true);
		ReplayText.gameObject.SetActive (false);
		Slained.gameObject.SetActive (false);
		Controlpage.gameObject.SetActive (true);
		gameOverLabel.gameObject.SetActive (true);	
		endScore.gameObject.SetActive (false);
		resetBtn.gameObject.SetActive (true);
		lifeLabel.gameObject.SetActive (false);
		scoreLabel.gameObject.SetActive (false);
		GameOverImage.gameObject.SetActive (true);
		endScore.text = scoreLabel.text;
		Time.timeScale = 0;


	}

	// Use this for initialization
	void Start () {
		StartGame();

	}


	

	
	// Update is called once per frame
	void Update () {

		endScore.text = scoreLabel.text;
		
	}
	// Restart Button

	public void ResetBtnClick(){
		
		initialize ();


	}
}
