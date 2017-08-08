using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingScript : MonoBehaviour {
	public CCManager ccMan;
	public BuffManager buffMan;
	public currentHPManager hpMan;
	public baseStatsManager baseMan;

	int ccIntGrow = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Q)) {
			CCObject derp = new CCObject (ccIntGrow, gameObject, 3.4f);
			ccMan.receiveCC (derp);
			ccIntGrow++;
		}
		if (Input.GetKeyDown (KeyCode.W)) {
			BuffObject derp = new BuffObject (1, gameObject, 5, 5f);
			buffMan.receiveCC (derp);
		}
		if (Input.GetKeyDown (KeyCode.E)) {
			currentHPChangeObj derp = new currentHPChangeObj (1, gameObject, 35);
			hpMan.receiveCC (derp);
		}
		if (Input.GetKeyDown (KeyCode.R)) {
			baseStatChangeObject derp = new baseStatChangeObject (1, gameObject, 20);
			baseMan.receiveCC (derp);
		}
	}
}

