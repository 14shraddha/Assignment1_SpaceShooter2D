//GameController

/*  Developed by Shraddhaben Patel 300821026
    Last Modified by Shraddhaben Patel
    Last Modified Date: Feb 4,2016
    This file is used for the whole game control.
    Like it does not belong to one specific asset.
    It goes to all the asset and do the functionality.*/


using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    //Private instance variables
    private int _scoreValue;
    private int _livesValue;

    //Public Access methods
    
    public int ScoreValue
    {
        get
        {
            return _scoreValue;
        }
        set
        {
            this._scoreValue = value;
            this.ScoreLable.text = "Score:" + this._scoreValue;
            Debug.Log(this._scoreValue);
        }
    }

    public int LivesValue
    {
        get
        {
            return _livesValue;
        }
        set
        {
            this._livesValue = value;

            if (this._livesValue <= 0)
            {
                this._endGame();
            }
            else
            {
                this._livesValue = value;
                this.LivesLable.text = "Lives:" + this._livesValue;
            }

        }
    }




    //Public instance variables
    public int birdNumber = 3; //to set the numbet of birds in the game

    // to get the instance from the other scripts
    public BirdController bird;
    public BalloonController balloon;
    public CoinController coin;

    //Public Instances
    public Text LivesLable;
    public Text ScoreLable;
    public Text GameOverLable;
    public Text HighScoreLable;
    public Button RestartButton;

    //Serialized Fields
    [SerializeField]
    private AudioSource _gameOverSound; //oto show thw variable in the insepector even if it is set as private


    // Use this for initialization
    void Start () {
        this._intitialize();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //********PRIVATE METHODS***********
    private void _intitialize()
    {
        this._scoreValue = 0;
        this._livesValue = 5;
        this.GameOverLable.enabled = false;
        this.HighScoreLable.enabled = false;
        this.RestartButton.gameObject.SetActive(false);

        for (int birdCount = 0; birdCount < this.birdNumber; birdCount++)
        {
            Instantiate(bird.gameObject);
        }
    }

    private void _endGame()
    {
       this.HighScoreLable.text = "High Score: " + this._scoreValue;
        this.GameOverLable.enabled = true;
        this.HighScoreLable.enabled = true;
        this.RestartButton.gameObject.SetActive(true);

        this.LivesLable.enabled = false;
        this.ScoreLable.enabled = false;
        this.balloon.gameObject.SetActive(false);
        this.coin.gameObject.SetActive(false);
        this._gameOverSound.Play();
    }

    //Public methods

    public void RestartButtonClick()
    {
        Application.LoadLevel("Garden");// to load the level of the game if resetbutton is pressed
    }


}
