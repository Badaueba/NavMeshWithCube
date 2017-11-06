using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestinationController : MonoBehaviour {

	Vector3 mousePosition, targetPosition;
	public AgentController agent;

	void FixedUpdate() {

		RaycastHit hit;
		if (Input.GetMouseButtonDown (0)) {
			if (Physics.Raycast (Camera.main.ScreenPointToRay (Input.mousePosition), out hit, 100)) {
				print ("hit point: " + hit.point);
				transform.position = new Vector3 (hit.point.x, 0f, hit.point.z);
				agent.Go ();
			}
		}
	}
}
