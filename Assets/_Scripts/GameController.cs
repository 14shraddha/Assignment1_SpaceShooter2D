using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

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
            Debug.Log(this._livesValue);
        }
    }




    //Public instance
    public int birdNumber = 3;
    public BirdController bird;


    // Use this for initialization
    void Start () {
        this._intitialize();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    private void _intitialize()
    {
        this._scoreValue = 0;
        this._livesValue = 5;

        for (int birdCount = 0; birdCount < this.birdNumber; birdCount++)
        {
            Instantiate(bird.gameObject);
        }
    }
}
