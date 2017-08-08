using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffManager : MonoBehaviour {
	public UnitScript UnitScriptRef;

	public void receiveCC(BuffObject IncomingBuffobj){

		if (IncomingBuffobj.BuffType == 1){
			buff1 ();
		}
		if (IncomingBuffobj.BuffType == 2){
			buff2 ();
		}
		if (IncomingBuffobj.BuffType == 3){
			buff3 ();
		}
		if (IncomingBuffobj.BuffType == 4){
			buff4 ();
		}
		if (IncomingBuffobj.BuffType == 5){
			buff5 ();
		}
		if (IncomingBuffobj.BuffType == 6){
			buff6 ();
		}
		if (IncomingBuffobj.BuffType == 7){
			buff7 ();
		}
		if (IncomingBuffobj.BuffType == 8){
			buff8 ();
		}
	}

	void buff1(){
		print ("buff1");
		UnitScriptRef.eventList.Add ("buff1");
	}
	void buff2(){
		print ("2");
	}
	void buff3(){
		print ("3");
	}
	void buff4(){
		print ("4");
	}
	void buff5(){
		print ("5");
	}
	void buff6(){
		print ("6");
	}
	void buff7(){
		print ("7");
	}
	void buff8(){
		print ("8");
	}
}
