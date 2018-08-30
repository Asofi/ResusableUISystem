using System.Collections;
using System.Collections.Generic;

using GB_UISystem;

using UnityEngine;

public class TestScreenButton : AUIScreenController {

	internal override void Show() {
		print("Show Button");
		_transitionIn.Animate(transform, () => {gameObject.SetActive(true);});
	}

	internal override void Hide() {
		print("Hide Button");
		_transitionIn.Animate(transform, () => {gameObject.SetActive(false);});
	}
}
