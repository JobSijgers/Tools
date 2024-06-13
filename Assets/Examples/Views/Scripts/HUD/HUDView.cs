using Examples.Views.Scripts.Pause;
using UnityEngine;
using UnityEngine.UI;
using Views;

namespace Examples.Views.Scripts.HUD
{
    public class HUDView : View
    {
        [SerializeField] private Button pauseButton;
        
        public override void Initialize()
        {
            base.Initialize();
            pauseButton.onClick.AddListener(OnResumeButtonClicked);
        }

        private void OnDestroy()
        {
            pauseButton.onClick.RemoveListener(OnResumeButtonClicked);
        }
        
        private void OnResumeButtonClicked()
        {
            ViewManager.ShowView<PauseView>();
        }
    }
}
