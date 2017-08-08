using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CCObject  {

	public int CCType;
	public GameObject CCSender;
	public float CCDuration;
	public GameObject LaunchTargetObj;
	public Vector2 launchTargetVect;


	//Root/Silence/KnockBack/Freeze Constructor
	public CCObject (int CCType, GameObject CCSender, float CCDuration){
		this.CCType = CCType;
		this.CCSender = CCSender;
		CCDuration = CCDuration;
	}
	//Hook/GoneFromGame/Freeze(ifpermanent) Constructor
	public CCObject (int CCType, GameObject CCSender){
		this.CCType = CCType;
		this.CCSender = CCSender;
	}
	//LaunchTo ConstructorObj

	public CCObject (int CCType, GameObject CCSender, GameObject targetObj){
		this.CCType = CCType;
		this.CCSender = CCSender;
		this.LaunchTargetObj = targetObj;
	}
	//LaunchTo ConstructorVect
	public CCObject (int CCType, GameObject CCSender, Vector2 LandTarget){
		this.CCType = CCType;
		this.CCSender = CCSender;
		this.launchTargetVect = LandTarget;
	}
}



/*  
* This is in the other class:
* note how the parameter that is in "receiveCC(CCObject derp1) is of type CC and not of type Object. 
* 
* 
* 
* public class Practice2 : MonoBehaviour {

	// Use this for initialization
	void Start () {

		CCObject derp = new CCObject (43, gameObject, 3.4f);
		receiveCC (derp);

	}

	// Update is called once per frame
	void Update () {

	}

	public Practice2 (int derp, string derp2){
	}
	public Practice2 (){

	}

	public void receiveCC (CCObject derp1){
		print (derp1);
	}

}
*/