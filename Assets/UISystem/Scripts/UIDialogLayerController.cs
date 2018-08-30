using System.Collections.Generic;

using UnityEngine;

namespace GB_UISystem {
    public class UIDialogLayerController : AUILayerController {
        const string DIALOG_PREFABS_PATH = "UI/Dialogs/";
        AUIScreenController[] _dialogsLibrary;
        List<AUIScreenController> _existingDialogs = new List<AUIScreenController>();
        Stack<AUIScreenController> _screenStack = new Stack<AUIScreenController>();

        void Awake() {
            SetupScreenControllers();
        }

        void SetupScreenControllers() {
            _dialogsLibrary = Resources.LoadAll<AUIScreenController>(DIALOG_PREFABS_PATH);
        }

        internal override void ShowScreen<T>() {
            // screen.Show();
            // _screenStack.Push(screen);
        }

        internal override void HideScreen<T>() {
            // screen.Hide();
        }
    }
}