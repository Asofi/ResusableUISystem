using System.Collections.Generic;

using UnityEngine;

namespace Airion.UI {
    public class UIPanelLayerController : AUILayerController {
        const string PANEL_PREFABS_PATH = "UI/Panels/";

        void Awake() {
            LoadScreenControllers(PANEL_PREFABS_PATH);
        }

        public override void ShowScreen<T>() {
            GetScreen<T>().Show();
        }

        public override void HideScreen<T>() {
            GetScreen<T>().Hide();
        }
    }
}