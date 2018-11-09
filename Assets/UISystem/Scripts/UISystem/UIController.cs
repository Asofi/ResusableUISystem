using System.Collections;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;

namespace Airion.UI {
    public class UIController : MonoBehaviour {

        public static UIController Instance => _instance;
        static UIController _instance;
        
        AUILayerController[] _layerControllers;
        
        void Awake() {
            if (_instance != null) {
                Destroy(gameObject);
                return;
            }

            _instance = this;
            _layerControllers = GetComponentsInChildren<AUILayerController>();
            DontDestroyOnLoad(gameObject);
        }

        void Update() {
            if (Input.GetKeyDown(KeyCode.Alpha1)) {
                Toggle<TestScreenButton>(LayerTypes.Panel);
            }
            
            if (Input.GetKeyDown(KeyCode.Alpha2)) {
                Toggle<TestScreenImage>(LayerTypes.Panel);
            }
            
            if (Input.GetKeyDown(KeyCode.Alpha3)) {
                Toggle<TestMenuDialog>(LayerTypes.Dialog);
            }
            if (Input.GetKeyDown(KeyCode.Alpha4)) {
                Toggle<TestShopDialog>(LayerTypes.Dialog);
            }
        }

        public UIScreenController GetScreen<T>(LayerTypes layer) where T : UIScreenController {
            return GetControllerByType(layer).GetScreen<T>();
        }

        public void Show<T>(LayerTypes layer) where T : UIScreenController {
            GetControllerByType(layer).ShowScreen<T>();
        }
        
        public void Hide<T>(LayerTypes layer) where T : UIScreenController {
            GetControllerByType(layer).HideScreen<T>();
        }
        
        public void Toggle<T>(LayerTypes layer) where T : UIScreenController {
            GetControllerByType(layer).ToggleScreen<T>();
        }

        AUILayerController GetControllerByType(LayerTypes layerType) {
            return _layerControllers.FirstOrDefault(x => x.LayerType == layerType);
        }
    }
}