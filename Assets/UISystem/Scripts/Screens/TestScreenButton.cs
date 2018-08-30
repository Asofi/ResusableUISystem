using System.Collections;
using System.Collections.Generic;

using GB_UISystem;

using UnityEngine;

public class TestScreenButton : AUIScreenController {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	internal override void Show() {
		print("Shows Button");
		gameObject.SetActive(true);
	}

	internal override void Hide() {
		gameObject.SetActive(false);
	}
}
