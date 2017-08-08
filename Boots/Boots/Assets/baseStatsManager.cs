using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baseStatsManager : MonoBehaviour {
	public UnitScript UnitScriptRef;
	public void receiveCC(baseStatChangeObject bscObj){

		if (bscObj.statChangeType == 1){
			bsc1 ();
		}
		if (bscObj.statChangeType == 2){
			bsc2 ();
		}
		if (bscObj.statChangeType == 3){
			bsc3 ();
		}
		if (bscObj.statChangeType == 4){
			bsc4 ();
		}
		if (bscObj.statChangeType == 5){
			bsc5 ();
		}
	}

	void bsc1(){
		print ("bsc1");
		UnitScriptRef.eventList.Add ("bsc1");
	}
	void bsc2(){
		print ("bsc2");
	}
	void bsc3(){
		print ("bsc3");
	}
	void bsc4(){
		print ("bsc4");
	}
	void bsc5(){
		print ("bsc5");
	}
}
