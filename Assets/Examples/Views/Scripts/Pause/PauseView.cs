using UnityEngine;
using UnityEngine.UI;
using Views;

namespace Examples.Views.Scripts.Pause
{
    public class PauseView : View
    {
        [SerializeField] private Button resumeButton;

        public override void Initialize()
        {
            base.Initialize();
            resumeButton.onClick.AddListener(OnResumeButtonClicked);
        }

        private void OnDestroy()
        {
            resumeButton.onClick.RemoveListener(OnResumeButtonClicked);
        }
        
        private void OnResumeButtonClicked()
        {
            ViewManager.ShowLastView();
        }
    }
}