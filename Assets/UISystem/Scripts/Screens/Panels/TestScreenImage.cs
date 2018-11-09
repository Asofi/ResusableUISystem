namespace Airion.UI {
    public class TestScreenImage : UIScreenController {

        public override void Show() {
            base.Show();
            print("Shows Image");
        }

        public override void Hide() {
            base.Hide();
            print("Hide Image");
        }
    }
}