using System;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;

namespace GB_UISystem {
    public abstract class AUILayerController : MonoBehaviour {
        public static event Action<AUIScreenController> ScreenRegistred;
        
        AUIScreenController[] _screensLibrary;
        List<AUIScreenController> _existingScreens = new List<AUIScreenController>();

        internal abstract void ShowScreen<T>() where T : AUIScreenController;
        internal abstract void HideScreen<T>() where T : AUIScreenController;

        protected void LoadScreenControllers(string path) {
            _screensLibrary = Resources.LoadAll<AUIScreenController>(path);
        }

        protected AUIScreenController GetScreen<T>() where T : AUIScreenController {
            return CheckExistence<T>()
                       ? _existingScreens.FirstOrDefault(x => x.GetType() == typeof(T))
                       : InstantiateScreen<T>();
        }

        bool CheckExistence<T>() where T : AUIScreenController {
            return _existingScreens.Any(x => x.GetType() == typeof(T));
        }

        AUIScreenController InstantiateScreen<T>() where T : AUIScreenController {
            var screenToCreate = LoadScreenFromLibrary<T>();
            if (CheckExistence<T>()) {
                throw new Exception($"[{name}] You tried to instantiate {typeof(T)} but there is already one.");
            }

            var createdScreen = Instantiate(screenToCreate, transform);
            createdScreen.gameObject.SetActive(false);
            ScreenRegistred?.Invoke(createdScreen);
            _existingScreens.Add(createdScreen);
            return createdScreen;
        }

        T LoadScreenFromLibrary<T>() where T : AUIScreenController {
            foreach (var screen in _screensLibrary) {
                if (screen.GetType() == typeof(T))
                    return (T) screen;
            }

            Debug.LogAssertion($"[{name}] There is no {typeof(T)} in the ScreensLibrary but you trying to load it.");
            return null;
        }
    }
}