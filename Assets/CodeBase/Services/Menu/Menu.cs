using CodeBase.CameraScripts;
using CodeBase.Services.UI;

namespace CodeBase.Services.Menu
{
    public class Menu : IMenu
    {
        private IWindowService _windowService;
        private MenuCamera _camera;

        public Menu(IWindowService windowService) => 
            _windowService = windowService;

        public void SetCamera(MenuCamera camera) => 
            _camera = camera;

        public void OpenMainMenu()
        {
            _windowService.OpenMainMenu();
            _camera.SetMainMenuPosition();
        }

        public void OpenCustomizationMenu()
        {
            _windowService.OpenCustomizationMenu();
            _camera.SetCustomizationMenuPosition();
        }
    
    }
}
