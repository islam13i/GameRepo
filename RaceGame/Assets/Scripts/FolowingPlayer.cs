﻿using UnityEngine;
using System.Collections;

public class FolowingPlayer : MonoBehaviour {

	public Transform player;
	public Vector3 offset;
	void Update () {

		transform.position = player.position + offset;
	} 
}