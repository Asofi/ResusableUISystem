using UnityEngine;

namespace Airion.UI {
    public class UIScreenController : MonoBehaviour {

        [SerializeField]
        LayerTypes _layerType;
        bool _isActive;

        public LayerTypes LayerType => _layerType;
        
        public void Toggle() {
            if(_isActive)
                Hide();
            else 
                Show();
        }

        public virtual void Show() {
            gameObject.SetActive(true);
            _isActive = true;
        }

        public virtual void Hide() {
            gameObject.SetActive(false);
            _isActive = false;
        }
    }
}