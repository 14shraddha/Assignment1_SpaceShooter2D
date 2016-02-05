//CoinController
/*  Developed by Shraddhaben Patel 300821026
    Last Modified by Shraddhaben Patel
    Last Modified Date: Feb 4,2016
    Coincontroller is the script that is used for the balloon coins in tha game.
    here the code for the random position of the coin is provided*/

using UnityEngine;
using System.Collections;

public class CoinController : MonoBehaviour {

    //PRIVATE INSTANCES
    private Transform _transform;
    private Vector2 _currentPosition;
    public float speed = 5f;

    //PUBLIC INSTANCES
    public float frontbound = -3194f;
    public float backbound = -3806f;
    public float upbound = 192f;
    public float downbound = -95f;

    // Use this for initialization
    void Start()
    {
        //make refrence to transform componnt in unity
        this._transform = gameObject.GetComponent<Transform>();
        this.Reset();
    }

    // Update is called once per frame
    void Update()
    {
        this._currentPosition = this._transform.position;
        this._currentPosition -= new Vector2(this.speed,0);
        this._transform.position = this._currentPosition;

        if (this._currentPosition.x <= backbound)
        {
            this.Reset();
        }
    }

    //PUBLIC METHODS
    public void Reset()
    {
        float yPosition = Random.Range(downbound, upbound);
        this._transform.position = new Vector2(frontbound, yPosition);

    }
}

