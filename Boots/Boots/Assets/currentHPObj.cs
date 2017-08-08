using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class currentHPChangeObj {

	public int hpChangeType;
	public GameObject hpChangeSender;
	public int hpChangeValue;

	//All StatChange Objs For now
	public currentHPChangeObj (int hpChangeType, GameObject hpChangeSender, int hpChangeValue){
		this.hpChangeType = hpChangeType;
		this.hpChangeSender = hpChangeSender;
		this.hpChangeValue = hpChangeValue;
	}
}
