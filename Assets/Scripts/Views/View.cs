using UnityEngine;

namespace Views
{
    public abstract class View : MonoBehaviour
    {
        [SerializeField] private ViewComponent[] viewComponents;


        public virtual void Initialize()
        {
            if (viewComponents == null || viewComponents.Length == 0)
                return;

            foreach (ViewComponent viewComponent in viewComponents)
            {
                viewComponent.Initialize();
            }
        }

        public virtual void Show()
        {
            gameObject.SetActive(true);
            foreach (ViewComponent viewComponent in viewComponents)
            {
                viewComponent.Show();
            }
        }

        public virtual void Hide()
        {
            gameObject.SetActive(false);
            foreach (ViewComponent viewComponent in viewComponents)
            {
                viewComponent.Hide();
            }
        }
    }
}