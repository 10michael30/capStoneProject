using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : 
MonoBehaviour {

	public Transform movingPlatform;
	public Transform position1;
	public Transform position2;
	public Vector3 newPostition;
	public string currentState;
	public float smooth;
	public float resetTime;

	// Use this for initialization
	void Start () {
		ChangeTarget ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		movingPlatform.position = Vector3.Lerp (movingPlatform.position, newPostition, smooth * Time.deltaTime); 
	}

	void ChangeTarget (){
		if (currentState.Equals("Moving To Position 1") )
		{
			currentState = "Moving To Position 2";
			newPostition = position2.position;
		}
		else if (currentState.Equals("Moving To Position 2")) 
		{
			currentState = "Moving To Position 1";
			newPostition = position1.position;
		}
		else if (currentState.Equals("")) 
		{
			
			currentState = "Moving To Position 2";
			newPostition = position2.position;
		}

		Invoke ("ChangeTarget", resetTime);
	}
}
