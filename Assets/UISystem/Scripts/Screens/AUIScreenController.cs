using UnityEngine;

namespace GB_UISystem {
    public abstract class AUIScreenController : MonoBehaviour {
        [SerializeField]protected AUITransitionAnim _transitionIn, _transitionOut;
        
        internal abstract void Show();
        internal abstract void Hide();
    }
}