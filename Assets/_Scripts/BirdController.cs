using UnityEngine;
using System.Collections;

public class BirdController : MonoBehaviour {

    private Transform _transform;
    private Vector2 _currentPosition;
    private float frontbound = -3168f;
    private float backbound = -3841f;
    private float upbound = 182f;
    private float downbound = -87f;
    private float _horizontalSpeed;
    private float _verticalDrift;

    public float minHspeed = 5f;
    public float maxHspeed = 10f;
    public float minVspeed = -2f;
    public float maxVspeed = 2f;



    // Use this for initialization
    void Start()
    {
        //make refrence to transform componnt in unity
        this._transform = gameObject.GetComponent<Transform>();

        // this._transform.position = new Vector2(0, 480f); // to create the position and always use vector to assign 

        this.Reset();
    }

    // Update is called once per frame
    void Update()
    {
        this._currentPosition = this._transform.position;
        this._currentPosition -= new Vector2(this._horizontalSpeed, this._verticalDrift);
        this._transform.position = this._currentPosition;

        if (this._currentPosition.x <= backbound)
        {
            this.Reset();
        }
    }

    public void Reset()
    {

        this._horizontalSpeed = Random.Range(this.minHspeed, this.maxHspeed);
        this._verticalDrift = Random.Range(this.maxVspeed, this.minVspeed);

        float yPosition = Random.Range(downbound, upbound);
        this._transform.position = new Vector2(frontbound, yPosition);

    }
}

