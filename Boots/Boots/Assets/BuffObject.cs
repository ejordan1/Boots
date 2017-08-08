using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffObject {

	public int BuffType;
	public GameObject BuffSender;
	public int BuffStrength;
	public float BuffDuration;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//All Buffs For now
	public BuffObject (int BuffType, GameObject BuffSender, int BuffStrength, float BuffDuration){
		this.BuffType = BuffType;
		this.BuffSender = BuffSender;
		this.BuffStrength = BuffStrength;
		this.BuffDuration = this.BuffDuration;
	}
}
