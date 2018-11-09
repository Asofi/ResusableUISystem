using System;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;

namespace Airion.UI {
    public abstract class AUILayerController : MonoBehaviour {
        protected UIScreenController[] _screensLibrary;
        protected List<UIScreenController> _existingScreens = new List<UIScreenController>();
        /// <summary>
        /// References from library to existing screen
        /// </summary>
        protected Dictionary<AUILayerController, AUILayerController> _screenTypesLibrary = new Dictionary<AUILayerController, AUILayerController>();
        
        [SerializeField]
        LayerTypes _layerType;
        public LayerTypes LayerType => _layerType;
        
        public abstract void ShowScreen<T>() where T : UIScreenController;
        public abstract void HideScreen<T>() where T : UIScreenController;
        
        public virtual void ToggleScreen<T>() where T : UIScreenController {
            GetScreen<T>().Toggle();
        }

        public UIScreenController GetScreen<T>() where T : UIScreenController {
            return CheckExistence<T>()
                       ? _existingScreens.FirstOrDefault(x => x.GetType() == typeof(T))
                       : InstantiateScreen<T>();
        }

        protected bool CheckExistence<T>() where T : UIScreenController {
            return _existingScreens.Any(x => x.GetType() == typeof(T));
        }

        protected UIScreenController InstantiateScreen<T>() where T : UIScreenController {
            var screenToCreate = LoadScreenFromLibrary<T>();
            if (CheckExistence<T>()) {
                throw new Exception($"[{name}] You tried to instantiate {typeof(T)} but there is already one.");
            }

            var createdScreen = Instantiate(screenToCreate, transform);   
            createdScreen.gameObject.SetActive(false);
            _existingScreens.Add(createdScreen);
            return createdScreen;
        }

        protected void LoadScreenControllers(string path) {
            _screensLibrary = Resources.LoadAll<UIScreenController>(path);
        }

        void FillExistingScreens() {
            _existingScreens.AddRange(GetComponentsInChildren<UIScreenController>());
        }

        T LoadScreenFromLibrary<T>() where T : UIScreenController {
            foreach (var screen in _screensLibrary) {
                if (screen.GetType() == typeof(T))
                    return (T) screen;
            }

            Debug.LogAssertion($"[{name}] There is no {typeof(T)} in the ScreensLibrary but you trying to load it.");
            return null;
        }
    }
}