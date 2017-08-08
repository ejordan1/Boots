using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baseStatChangeObject {

	public int statChangeType;
	public GameObject statChangeSender;
	public int statChangeValue;

	//All StatChange Objs For now
	public baseStatChangeObject (int statChangeType, GameObject statChangeSender, int statChangeValue){
		this.statChangeType = statChangeType;
		this.statChangeSender = statChangeSender;
		this.statChangeValue = statChangeValue;
	}
}
