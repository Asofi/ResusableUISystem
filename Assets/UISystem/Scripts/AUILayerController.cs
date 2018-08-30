using System;
using System.Collections.Generic;

using UnityEngine;

namespace GB_UISystem {
    public abstract class AUILayerController : MonoBehaviour {
        protected AUIScreenController[] _screensLibrary;
        protected List<AUIScreenController> _existingScreens;
        protected Dictionary<Type, AUILayerController> _screenTypesLibrary;

        internal abstract void ShowScreen<T>() where T : AUIScreenController;
        internal abstract void HideScreen<T>() where T : AUIScreenController;

        protected bool CheckExistence<T>() where T : AUIScreenController {
            return _existingScreens.Contains(LoadScreenFromLibrary<T>());
        }

        protected void InstantiateScreen<T>() where T : AUIScreenController {
            var createdScreen = LoadScreenFromLibrary<T>();
            if (_existingScreens.Contains(createdScreen)) {
                Debug.LogError($"[{name}] You tried to instantiate {typeof(T)} but there is already one.");
            } else {
                _existingScreens.Add(createdScreen);
            }
        }

        protected void LoadScreenControllers(string path) {
            _screensLibrary = Resources.LoadAll<AUIScreenController>(path);
        }

        T LoadScreenFromLibrary<T>() where T : AUIScreenController {
            foreach (var screen in _screensLibrary) {
                if ( screen.GetType() ==  typeof(T))
                    return (T) screen;
            }

            Debug.LogAssertion($"[{name}] There is no {typeof(T)} in the ScreensLibrary but you trying to load it.");
            return null;
        }
    }
}