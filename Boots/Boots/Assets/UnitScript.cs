using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitScript : MonoBehaviour {

	public ArrayList eventList = new ArrayList();
	public GameObject[] targetPriorityArray = new GameObject[10];
	public GameObject finalTarget;

	public float moveSpeed = .5f;

	void Update(){



		for (int i = targetPriorityArray.Length; i < 0; i--) {
			if (targetPriorityArray [i] != null) {
				finalTarget = targetPriorityArray [i];
				break;
			}
		}
			
		if (Input.GetKeyDown (KeyCode.T)) {
			for (int i = 0; i < eventList.Count; i++) {
				print (eventList [i]);
			}
		}
	} 

	void movementController(){
		if (Vector2.Distance (gameObject.transform.position, finalTarget.transform.position) < .2f) {
			gameObject.transform.Translate (finalTarget.transform.position * moveSpeed);
		}
	}
}
