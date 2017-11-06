using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavDestination : MonoBehaviour {

	public Transform destination; 
	NavMeshAgent navMeshAgent;

	// Use this for initialization
	void Start () {
		navMeshAgent = this.GetComponent<NavMeshAgent> ();
		Go ();
	}
	
	void Go() {
		if (destination != null) {
			Vector3 pos = destination.position;
			navMeshAgent.SetDestination (pos);
		}
	}
}
