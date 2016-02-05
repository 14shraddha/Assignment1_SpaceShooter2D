//SkyController
/*  Developed by Shraddhaben Patel 300821026
    Last Modified by Shraddhaben Patel
    Last Modified Date: Feb 4,2016
    The skycontroller is used for the background.
    Here the code for the scolling background is provided */

using UnityEngine;
using System.Collections;

public class SkyController : MonoBehaviour {

    //PRIVATE INSTANCES
    private Transform _transform;
    private Vector2 _currentPosition;
    public float speed = 5;

    // Use this for initialization
    void Start () {
        //make refrence to transform componnt in unity
        this._transform = gameObject.GetComponent<Transform>();
        this.Reset();
    }
	
	// Update is called once per frame
	void Update () {

        this._currentPosition = this._transform.position;
        this._currentPosition -= new Vector2(this.speed,0);
        this._transform.position = this._currentPosition;

        if (this._currentPosition.x <=-4198)
        {
            this.Reset();
        }

    }

    //PUBLIC METHODS
    public void Reset()
    {
        this._transform.position = new Vector2(-2803,0);
    }
}
