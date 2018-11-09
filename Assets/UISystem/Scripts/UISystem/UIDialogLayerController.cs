using System.Collections.Generic;

using UnityEngine;

namespace Airion.UI {
    public class UIDialogLayerController : AUILayerController {
        const string DIALOG_PREFABS_PATH = "UI/Dialogs/";
        UIScreenController[] _dialogsLibrary;
        UIScreenController _activeScreen;

        void Awake() {
            LoadScreenControllers(DIALOG_PREFABS_PATH);
        }
        
        //Now showing new dialog is automaticly disables old active screen
        public override void ToggleScreen<T>() {
            ShowScreen<T>();
        }

        public override void ShowScreen<T>() {
            var screen = GetScreen<T>();
            if(_activeScreen)
                _activeScreen.Hide();

            _activeScreen = screen;
            screen.Show();
        }

        public override void HideScreen<T>() {
            var screen = GetScreen<T>();
            screen.Hide();
            _activeScreen = null;
        }
    }
}