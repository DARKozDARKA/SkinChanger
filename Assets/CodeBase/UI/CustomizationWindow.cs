using System.Collections.Generic;
using CodeBase.Services.CharacterCustomizator;
using CodeBase.Services.Menu;
using CodeBase.StaticData.Enums;
using UnityEngine;
using Zenject;

namespace CodeBase.UI
{
    public class CustomizationWindow : Window
    {
        [SerializeField]
        private List<CustomizationPartButton> _buttons;

        [SerializeField]
        private ButtonHandler _exitButton;

        private ICharacterCustomizator _characterCustomizator;
        private IMenu _menu;

        [Inject]
        private void Construct(ICharacterCustomizator characterCustomizator, IMenu menu)
        {
            _menu = menu;
            _characterCustomizator = characterCustomizator;
        }

        private void OnEnable()
        {
            _buttons.ForEach(_ => _.OnPressed += OnButtonPressed);
            _exitButton.Pressed += Exit;
        }
    
        private void OnDisable()
        {
            _buttons.ForEach(_ => _.OnPressed -= OnButtonPressed);
            _exitButton.Pressed -= Exit;
        }


        private void OnButtonPressed(CustomizationPartType partType, CustomizationPartButtonType buttonType)
        {
            switch (buttonType)
            {
                case CustomizationPartButtonType.Next:
                    _characterCustomizator.SetNextCustom(partType);
                    break;
                case CustomizationPartButtonType.Previous:
                    _characterCustomizator.SetPrevoiusCustom(partType);
                    break;
            }
        }

        private void Exit() => 
            _menu.OpenMainMenu();
    }
}