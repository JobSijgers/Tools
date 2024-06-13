using TMPro;
using UnityEngine;
using Views;

namespace Examples.Views.Scripts.HUD
{
    public class HealthUI : ViewComponent
    {
        [SerializeField] private TMP_Text healthText;
        protected override void Show()
        {
            healthText.text = $"Health:{Random.Range(0, 101)}";
        }

        protected override void Hide()
        {
            healthText.text = string.Empty;
        }
    }
}
