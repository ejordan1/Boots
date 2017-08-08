using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCManager : MonoBehaviour {

	public UnitScript UnitScriptRef;

	int incomingCCType = 0;
	int currentCCType = 0;

	CCObject currentCCobj;
	CCObject IncomingCCType;
	public GameObject SenderOfCC;


	public bool rooted;
	public bool silenced;
	public bool frozen;
	public bool	petrified;
	public bool knockedBack;
	public bool hooked;
	public bool knockedUp;
	public bool goneFromGamed;
	public bool launchedTo;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//could I pass in the object CCObject that would have different fields based on what the CC is?
	public void receiveCC(CCObject incomingCCobj){
		incomingCCType = incomingCCobj.CCType;
		if (incomingCCType >= currentCCType){ 
			currentCCType = incomingCCType;
			currentCCobj = incomingCCobj;


			if (currentCCType == 1){
				root ();
			}
			if (currentCCType == 2){
				silence ();
			}
			if (currentCCType == 3){
				hook ();
			}
			if (currentCCobj.CCType == 4){
				knockBack ();
			}
			if (currentCCobj.CCType == 5){
				freeze ();
			}
			if (currentCCobj.CCType == 6){
				launchTo ();
			}
			if (currentCCobj.CCType == 11){
			}
			if (currentCCobj.CCType == 12){
			}
			if (currentCCobj.CCType == 13){
			}
			if (currentCCobj.CCType == 20){
				petrify ();
			}
			if (currentCCobj.CCType == 21){
			}
		}

	}
		
	void root(){
		print ("CC1");
		UnitScriptRef.eventList.Add ("cc1");
	}
	void silence(){
		print ("2");
	}
	void hook(){
		print ("3");
	}
	void knockBack(){
		print ("4");
	}
	void petrify(){
		print ("5");
	}
	void freeze(){
		print ("6");
	}
	void knockUp(){
		print ("7");
	}
	void launchTo(){
		print ("8");
	}
	void goneFromGame(){
		print ("9");
	}
}
