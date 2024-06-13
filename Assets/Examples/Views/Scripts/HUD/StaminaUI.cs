using TMPro;
using UnityEngine;
using Views;

namespace Examples.Views.Scripts.HUD
{
    public class StaminaUI : ViewComponent
    {
        [SerializeField] private TMP_Text staminaText;
        protected override void Show()
        {
            staminaText.text = $"Stamina:{Random.Range(0, 101)}";
        }

        protected override void Hide()
        {
            staminaText.text = string.Empty;
        }
    }
}