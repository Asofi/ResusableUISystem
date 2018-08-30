using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace GB_UISystem {
    public class UIController : MonoBehaviour {

        public void Show<T>(T screen) where T: AUIScreenController {
            
        }

        public void Hide<T>(T screen) where T: AUIScreenController {
            
        }
    }
}