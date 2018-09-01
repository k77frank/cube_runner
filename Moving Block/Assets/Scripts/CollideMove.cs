using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideMove : MonoBehaviour {

	public PlayerMovement movement;

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "obstacle")
		{
			movement.enabled = false;
			FindObjectOfType<GameManager> ().EndGame ();
		}

	}

}
