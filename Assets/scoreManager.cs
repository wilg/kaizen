﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class scoreManager : MonoBehaviour {

	public static scoreManager instance;
	public float currentScore;
	// Use this for initialization
	void Start () {
	}

	void Awake() {
		instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (currentScore);
	}

	public void AddPoints(int pointsToAdd){
		currentScore += pointsToAdd;
		Debug.Log ("You Score is: " + currentScore);
	}
}
