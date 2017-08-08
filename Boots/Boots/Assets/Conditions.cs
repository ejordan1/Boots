using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditions : MonoBehaviour {

	CCManager ccRef;

	void Start(){
		ccRef = gameObject.GetComponent<CCManager>();
	}


	//getInfo methods

	//ABILITY CASTING CHECKS
	public bool unitCastingAnyAbility(){
		//is unit currently casting an ability? 
		return false;
	}
	public bool currentlyCastingAbilityI(string abilityName, GameObject selectedUnit){
		//is unit currently casting an ability?
		return false;
	}

	//TARGET CHECKS
	public bool hasTarget(GameObject selectedUnit){
		//does the selected unit have a target?
		return false;
	}
	public bool isTargetMe(GameObject selectedUnit){
		//is the selected unit's target me?
		return false;
	}
	public GameObject whatIsTarget(GameObject selectedUnit){
		//what is the selected unit's target?
		return null;

	}
	public bool isTargetCCd (GameObject selectedUnit){
		//returns true if target is being CCd
		return false;
	}

	//OTHER CROWD CONTROL CHECKS: how do to the get component stuff in an efficient way? should it automatically get all those things when it becomes the target?
	public bool isTargetSilenced(GameObject selectedUnit){
		
		return selectedUnit.GetComponent<CCManager>().silenced;
	}
	public bool isTargetRooted(GameObject selectedUnit){
		return selectedUnit.GetComponent<CCManager>().rooted;
	}
	public bool isTargetHooked(GameObject selectedUnit){
		//returns true if target is hooked
		return selectedUnit.GetComponent<CCManager>().hooked;
	}
	public bool isTargetKnockedBack(GameObject selectedUnit){
		//returns true if target is being knockedBack
		return selectedUnit.GetComponent<CCManager>().knockedBack;
	}
	public bool isTargetPetrified(GameObject selectedUnit){
		//returns true if target is petrified
		return selectedUnit.GetComponent<CCManager>().petrified;
	}
	public bool isTargetFrozen(GameObject selectedUnit){
		//returns true if target is frozen
		return selectedUnit.GetComponent<CCManager>().frozen;
	}
	public bool isTargetKnockedUp(GameObject selectedUnit){
		//returns true if target is knockedUp
		return selectedUnit.GetComponent<CCManager>().knockedUp;
	}
	public bool isTargetLaunched(GameObject selectedUnit){
		//returns true if target is knockedUp
		return selectedUnit.GetComponent<CCManager>().launchedTo;
	}



	//POSITION CHECKS
	public Vector2 locationBehindTarget (float distanceBehind, GameObject selected){
		//returns a vector a specified distance behind the target in respect to you
		return new Vector2 (0,0);
	}
	public float angleMeToTarget (GameObject target){
		//returns float of angle of target in respect to currently face direction of you
		return 0;
	}
	public float angleTargetTowardMe (GameObject target){
		//returns float of angle of me in respect to currently face direction of target
		return 0;
	}

	//STAT CHECKS

	public int targetMaxHealth (GameObject selectedUnit){
		//returns targetMaxHealth
		return 0;
	}
	public float targetMoveSpeed (GameObject selectedUnit){
		//returns the regular moveSpeed of the target
		return 0;
	}
	public int targetArmor(GameObject selectedUnit){
		//returns target current armor
		return 0;
	}
	public int targetSize (GameObject selectedUnit){
		//returns target current size
		return 0;
	}
	public int targetWeight (GameObject selectedUnit){
		//returns target current weight
		return 0;
	}
	public int targetUnitCost (GameObject selectedUnit){
		//returns target unitCost
		return 0;
	}

	//CURRENT STATUS CHECKS
	public float targetCurrentSpeed (GameObject selectedUnit){
		//returns the targets current speed they are moving at: this includes CC effects, abilities, etc.
		return 0;
	}
	public int targetCurrentHealth(GameObject selectedUnit){
		//returns targetCurrentHealth
		return 0;
	}
	public bool targetReviving (GameObject selectedUnit){
		//returns true if target is in reviving animation
		return false;
	}
	public bool targetDying (GameObject selectedUnit){
		//returns true if target is in death animation
		return false;
	}
	public bool isTakingDamage (GameObject selectedUnit){
		//returns true if target is taking damage
		return false;
	}
	public bool amITakingDamage (GameObject selectedUnit){
		//returns true if target is taking damage
		return false;
	}

	//UPGRADE CHECKS
	public int targetUpgradeLevel (GameObject selectedUnit){
		//returns target current upgrade level
		return 0;
	}
	public bool targetUpgrading (GameObject selectedUnit){
		//returns true if target is in upgrade animation
		return false;
	}



	//searchEventList methods

	//INSTANT FEEDBACK (immediate feedback)

	public int targetDamageFor (GameObject selectedUnit){
		//returns how much the target was damaged for
		return 0;
	}
	public bool isTargetTakingLethalDamage (GameObject selectedUnit){
		//returns true if target is taking lethal damage
		return false;
	}
	public bool killedUnit (GameObject selectedUnit){
		//returns true if you killed unit
		return false;
	}
	public bool areTheyStillHookedByMe (GameObject selectedUnit){
		//returns true if target is currently being hooked by you
		//used to determine if you successfully hooked the target/if they are still hooked
		return false;
	}
	public bool areTheyStillHooking (GameObject selectedUnit){
		//return true if the hooker is still hooking you: the hooked target uses this to determine
		//whether they something happened to the hooker to see if they should still be hooked
		return false;
	}
	public bool unitStillXBuffedByMe (int buffType, GameObject selectedUnit){
		//returns true if unit is still receiving your buff
		//used to determine whether they successfully received your buff, and are still
		return false;
	}
	public bool unitReceivedMyRevive(){
		//returns true if unit was successfully revived by me (only is known after revive animation)
		return false;
	}

	//LONGER SEARCHES
	public int totalDamageTakenEntireGame(){
		//returns total damage taken by unit over the entire game
		return 0;
	}
	public int totalDamageSinceLastRevive(){
		//returns total damage taken since revived
		return 0;
	}
	public int nDeaths(){
		//returns total number of unit deaths
		return 0;
	}
	public int nTimesRevived(){
		//returns number of times unit has revived
		return 0;
	}
	public int nTimesRevivedAnother(){
		//returns number of units another unit has successfuly revived
		return 0;
	}
	public int totalLifeStolen(){
		//returns totalLifeStolen from other units over entire game
		return 0;
	}
	public int nTimesAbilityCast(string abilityName){
		//returns number of times specified ability number has been cast
		return 0;
	}
	public int enemiesKilledLastXSeconds(int seconds, GameObject selectedUnit){
		//returns the number of enemies a unit has killed in the last X seconds
		return 0;
	}
	public float timeSinceDamaged (GameObject selectedUnit){
		//returns seconds since unit was last damaged
		return 0;
	}
	public int nAbilityXUsedOnTarget (string abilityName, GameObject selectedUnit){
		//returns number of times an ability was used on the unit
		return 0;
	}
	public float timePastSinceExecutedEventX (float seconds, string eventName){
		//returns seconds past since unit executed event "X"
		return 0;
	}
	public float timeSinceReceivedEventX (float seconds, string eventName){
		//returns seconds past since unit received event "X"
		return 0;
	}
}
