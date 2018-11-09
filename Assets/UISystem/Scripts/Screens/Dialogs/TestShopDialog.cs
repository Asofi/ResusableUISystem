using Airion.UI;

using UnityEngine;

public class TestShopDialog : UIScreenController {
    public override void Show() {
        base.Show();
        Debug.Log("Shows TestShop");
    }

    public override void Hide() {
        base.Hide();
        Debug.Log("Hides TestShop");
    }
}
