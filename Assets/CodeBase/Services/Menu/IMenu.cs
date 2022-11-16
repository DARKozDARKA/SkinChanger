using CodeBase.CameraScripts;

namespace CodeBase.Services.Menu
{
    public interface IMenu
    {
        void SetCamera(MenuCamera camera);
        void OpenMainMenu();
        void OpenCustomizationMenu();
    }
}