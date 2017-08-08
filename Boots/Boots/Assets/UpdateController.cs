using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateController : MonoBehaviour {
	public UnitScript unitScriptRef;
	public int hpc1Count;
	int countNeededToUpgrade = 15;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		hpc1Count = 0;
		for (int i = 0; i < unitScriptRef.eventList.Count; i++) {
			if (unitScriptRef.eventList[i] == ("hpc1")){
				hpc1Count ++;
			}
			if (hpc1Count == countNeededToUpgrade) {
				print ("unit upgrade!");
				countNeededToUpgrade = countNeededToUpgrade + 20;
			}
		}
	}
}
