using UnityEngine;
using System.Collections;

public class OnCollider : MonoBehaviour {
	public float haveforce=12f;
	
	void OnCollisionEnter(Collision collider) {
		Debug.Log ("enter colision");
	}
	
	void OnCollisionStay (Collision collider) {
		Debug.Log ("Stay collision");
		
	}
	void OnCollisionExit(Collision collider){
		Debug.Log ("Exit collision");
	}
	
	void OnTriggerEnter(Collider collider) {
		Debug.Log ("Enter trigger");
	}
	
	void OnTriggerStay (Collider collider) {
		collider.rigidbody.AddForce(Vector3.up * haveforce,ForceMode.Acceleration);
		Debug.Log ("Trigger Stay");
		
	}
	void OnTriggerExit(Collider collider){
		Debug.Log ("Exit trigger");
	}
}
