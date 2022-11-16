using System;
using UnityEngine;
using UnityEngine.UI;

namespace CodeBase.UI
{
    public class ButtonHandler : MonoBehaviour, IButtonHandler
    {
        [SerializeField]
        private Button _button;

        public Action Pressed { get; set; }

        private void OnEnable() => 
            _button.onClick.AddListener(PressButton);

        private void PressButton() =>
            Pressed?.Invoke();
    }
}