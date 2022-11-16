using System;
using CodeBase.StaticData.Enums;
using UnityEngine;

namespace CodeBase.UI
{
    public class CustomizationPartButton : MonoBehaviour
    {
        [SerializeField]
        private CustomizationPartButtonType _buttonType;

        [SerializeField]
        private CustomizationPartType _type;

        [SerializeField]
        private ButtonHandler _buttonHandler;

        public Action<CustomizationPartType, CustomizationPartButtonType> OnPressed;

        private void OnEnable() => 
            _buttonHandler.Pressed += HandlePress;
    
        private void OnDisable() => 
            _buttonHandler.Pressed -= HandlePress;

        private void HandlePress() => 
            OnPressed?.Invoke(_type, _buttonType);
    }
}