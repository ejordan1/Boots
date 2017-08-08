using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class currentHPManager : MonoBehaviour {
	public UnitScript UnitScriptRef;
	public int currentHP;

	// Update is called once per frame
	void Update () {
		//if hp goes below 0, do death method. If unit dead and hp is above 0, do revive method.  
	}

		public void receiveCC(currentHPChangeObj hpcObj){

			if (hpcObj.hpChangeType == 1){
				hpc1 ();
			}
			if (hpcObj.hpChangeType == 2){
				hpc2 ();
			}
		}

		void hpc1(){
			print ("hpc1");
			UnitScriptRef.eventList.Add ("hpc1");

		}
		void hpc2(){
			print ("hpc2");
	}
}
