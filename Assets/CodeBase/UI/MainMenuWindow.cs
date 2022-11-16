using CodeBase.Services.Menu;
using UnityEngine;
using Zenject;

namespace CodeBase.UI
{
    public class MainMenuWindow : Window
    {
        [SerializeField]
        private ButtonHandler _openCustomizationButton;

        private IMenu _menu;


        [Inject]
        private void Constuct(IMenu menu)
        {
            _menu = menu;
        }
    
        private void OnEnable() => 
            _openCustomizationButton.Pressed += Pressed;
    
        private void OnDisable() => 
            _openCustomizationButton.Pressed -= Pressed;
    
        private void Pressed()
        {
            _menu.OpenCustomizationMenu();
        }
    }
}