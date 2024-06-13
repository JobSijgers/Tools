using System;
using UnityEngine;
using UnityEngine.Events;

namespace Views
{
    public abstract class ViewComponent : MonoBehaviour
    {
        public virtual void Initialize(UnityEvent onShow, UnityEvent onHide)
        {
            onShow.AddListener(Show);
            onHide.AddListener(Hide);
        }
        protected abstract void Show();
        protected abstract void Hide();
    }
}