using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSelectFunctions : MonoBehaviour {
	GameObject cam;

	WorldInfo wRef;
	Conditions cRef;

	void Start(){
		cam = GameObject.Find ("Main Camera");
		wRef = cam.GetComponent<WorldInfo> ();
		cRef = gameObject.GetComponent<Conditions> (); //Is this how I should do this?
	}



	int nAnyUnitsWithinXOf(float xDistance, Vector2 pos){
		int numberOfUnits = 0;
		foreach (GameObject unit in wRef.allUnits){
			if (Vector2.Distance (unit.transform.position, pos) < xDistance) {
				numberOfUnits++;
			}
		}
		return numberOfUnits;
	}

	int nTeam1UnitsWithinXOf(float xDistance, Vector2 pos){
		int numberOfUnits = 0;
		foreach (GameObject unit in wRef.team1Units){
			if (Vector2.Distance (unit.transform.position, pos) < xDistance) {
				numberOfUnits++;
			}
		}
		return numberOfUnits;
	}
	int nTeam2UnitsWithinXOf(float xDistance, Vector2 pos){
		int numberOfUnits = 0;
		foreach (GameObject unit in wRef.team2Units){
			if (Vector2.Distance (unit.transform.position, pos) < xDistance) {
				numberOfUnits++;
			}
		}
		return numberOfUnits;
	}
	int nTeam3UnitsWithinXOf(float xDistance, Vector2 pos){
		int numberOfUnits = 0;
		foreach (GameObject unit in wRef.team2Units){
			if (Vector2.Distance (unit.transform.position, pos) < xDistance) {
				numberOfUnits++;
			}
		}
		return numberOfUnits;
	}




	ArrayList arrayAnyUnitsWithinXOf(float xDistance, Vector2 pos){
		ArrayList units = new ArrayList ();
		foreach (GameObject unit in wRef.allUnits){
			if (Vector2.Distance (unit.transform.position, pos) < xDistance) {
				units.Add (unit);
			}
		}
		return units;
	}

	ArrayList arrayTeam1UnitsWithinXOf(float xDistance, Vector2 pos){
		ArrayList units = new ArrayList ();
		foreach (GameObject unit in wRef.allUnits){
			if (Vector2.Distance (unit.transform.position, pos) < xDistance) {
				units.Add (unit);
			}
		}
		return units;
	}
	ArrayList arrayTeam2UnitsWithinXOf(float xDistance, Vector2 pos){
		ArrayList units = new ArrayList ();
		foreach (GameObject unit in wRef.allUnits){
			if (Vector2.Distance (unit.transform.position, pos) < xDistance) {
				units.Add (unit);
			}
		}
		return units;
	}
	ArrayList arrayTeam3UnitsWithinXOf(float xDistance, Vector2 pos){
		ArrayList units = new ArrayList ();
		foreach (GameObject unit in wRef.allUnits){
			if (Vector2.Distance (unit.transform.position, pos) < xDistance) {
				units.Add (unit);
			}
		}
		return units;
	}

	ArrayList enemyUnitsFacingTowardsX(float xDistance, Vector2 pos){
		ArrayList units = new ArrayList ();
		foreach (GameObject unit in wRef.allUnits){
			if (Vector2.Distance (unit.transform.position, pos) < xDistance) {
				if (cRef.angleTargetTowardMe (unit)< 30){units.Add(unit);}
			}
		}
		return units;
	}
	//ArrayList unitsXCriteria (){
	//here I want to be able to give criteria as parameters somehow so I can combine these parameters and do this with any getInfo check 
	//without making an entirely new method
	//}

}
