﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Acolades : MonoBehaviour {

	public List<GameObject> statTrackers = new List<GameObject>();

	bool sorted;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Compare all the statTrackers
		//Compare elusiveScore
		if (!sorted) {
			for (int i = 0; i < statTrackers.Count; i++) {
				//if (statTrackers [i].GetComponent<StatTracker> ().elusiveScore () >= statTrackers [i + 1].GetComponent<StatTracker> ().elusiveScore ()) {
					//statTrackers[i]
				}
			}
	}
}
