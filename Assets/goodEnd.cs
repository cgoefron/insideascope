﻿using UnityEngine;
using System.Collections;

public class goodEnd : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			Application.LoadLevel ("GoodEnd");
		}
	
	}
	
	}

