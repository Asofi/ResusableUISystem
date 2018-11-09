using Airion.UI;
using UnityEngine;

public class TestMenuDialog : UIScreenController {

	public override void Show() {
		base.Show();
		Debug.Log("Shows TestMenu");
	}

	public override void Hide() {
		base.Hide();
		Debug.Log("Hides TestMenu");
	}
}
