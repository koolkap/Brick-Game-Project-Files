using UnityEngine;
using System.Collections;

public class PowerUpScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody>().AddTorque( Vector3.forward * 10f );	
	}
	

	
	void OnCollisionEnter( Collision col ) {
		Destroy ( gameObject );
	}
}
