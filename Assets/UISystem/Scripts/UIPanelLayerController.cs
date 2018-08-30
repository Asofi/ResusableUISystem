using System.Collections.Generic;

using UnityEngine;

namespace GB_UISystem {
    public class UIPanelLayerController : AUILayerController {
        const string PANEL_PREFABS_PATH = "UI/Panels/";

        void Awake() {
            LoadScreenControllers(PANEL_PREFABS_PATH);
            ShowScreen<TestScreenButton>();
        }

        internal override void ShowScreen<T>() {
            if (!CheckExistence<T>()) {
                InstantiateScreen<T>();
            }
        }

        internal override void HideScreen<T>() {
            // screen.Hide();
        }
    }
}