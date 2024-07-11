using UnityEngine;

namespace Views
{
    public abstract class ViewComponent : MonoBehaviour
    {
        public abstract void Initialize();
        public abstract void Show();
        public abstract void Hide();
    }
}