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
    public int birdNumber = 3;
    public BirdController bird;
    public BalloonController balloon;
    public CoinController coin;
    public Text LivesLable;
    public Text ScoreLable;
    public Text GameOverLable;
    public Text HighScoreLable;
    //public Button RestartButton;

    //Serialized Fields
    [SerializeField]
    private AudioSource _gameOverSound;


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
       // this.RestartButton.enabled = false;

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
        //this.RestartButton.enabled = true;

        this.LivesLable.enabled = false;
        this.ScoreLable.enabled = false;
        this.balloon.gameObject.SetActive(false);
        this.coin.gameObject.SetActive(false);
        this._gameOverSound.Play();
    }



}
