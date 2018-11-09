using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Airion.UI {
    public class TestScreenButton : UIScreenController {

        public override void Show() {
            base.Show();
            print("Shows Button");
        }

        public override void Hide() {
            base.Hide();
            print("Hides Button");
        }
    }
}