using System.Collections;
using System.Collections.Generic;

using GB_UISystem;

using UnityEngine;

public class TestScreenImage : AUIScreenController {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	internal override void Show() {
		print("Shows Image");
		gameObject.SetActive(true);
	}

	internal override void Hide() {
		print("Hide Image");
		gameObject.SetActive(false);
	}
}
