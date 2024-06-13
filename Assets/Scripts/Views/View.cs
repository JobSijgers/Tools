using System;
using UnityEngine;
using UnityEngine.Events;

namespace Views
{
    public abstract class View : MonoBehaviour
    {
        [SerializeField] private ViewComponent[] viewComponents;
        private readonly UnityEvent onOpen = new();
        private readonly UnityEvent onClose = new();

        public virtual void Initialize()
        {
            if (viewComponents == null || viewComponents.Length == 0)
                return;

            foreach (ViewComponent viewComponent in viewComponents)
            {
                viewComponent.Initialize(onOpen, onClose);
            }
        }

        public virtual void Show()
        {
            gameObject.SetActive(true);
            onOpen?.Invoke();
        }

        public virtual void Hide()
        {
            gameObject.SetActive(false);
            onClose?.Invoke();
        }

        private void OnDestroy()
        {
            onOpen.RemoveAllListeners();
            onClose.RemoveAllListeners();
        }
    }
}