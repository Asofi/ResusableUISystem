using System.Collections.Generic;

using UnityEngine;

namespace GB_UISystem {
    public class UIPanelLayerController : AUILayerController {
        const string PANEL_PREFABS_PATH = "UI/Panels/";

        bool tempFlag1 = true;
        bool tempFlag2 = true;

        void Awake() {
            LoadScreenControllers(PANEL_PREFABS_PATH);
            // ShowScreen<TestScreenImage>();
        }

        void Update() {
            if (Input.GetKeyDown(KeyCode.Alpha1)) {
                if (tempFlag1) {
                    ShowScreen<TestScreenImage>();
                } else {
                    HideScreen<TestScreenImage>();
                }
                tempFlag1 = !tempFlag1;
            }
            
            if (Input.GetKeyDown(KeyCode.Alpha2)) {
                if (tempFlag2) {
                    ShowScreen<TestScreenButton>();
                } else {
                    HideScreen<TestScreenButton>();
                }
                tempFlag2 = !tempFlag2;
            }
        }

        internal override void ShowScreen<T>() {
            GetScreen<T>().Show();
        }

        internal override void HideScreen<T>() {
            GetScreen<T>().Hide();
        }
    }
}