using TMPro;
using UnityEngine;
using Views;

namespace Examples.Views.Scripts.HUD
{
    public class HealthUI : ViewComponent
    {
        [SerializeField] private TMP_Text healthText;

        public override void Initialize() { }

        public override void Show()
        {
            healthText.text = $"Health:{Random.Range(0, 101)}";
        }

        public override void Hide()
        {
            healthText.text = string.Empty;
        }
    }
}