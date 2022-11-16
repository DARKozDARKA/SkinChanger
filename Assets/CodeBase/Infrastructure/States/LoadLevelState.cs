using CodeBase.CameraScripts;
using CodeBase.Customization;
using CodeBase.Services.CharacterCustomizator;
using CodeBase.Services.Data;
using CodeBase.Services.Factory;
using CodeBase.Services.Menu;
using CodeBase.Services.UI;
using CodeBase.Services.Unity;
using CodeBase.StaticData.ScriptableObjects;
using CodeBase.StaticData.Strings;
using UnityEngine;
using Zenject;

namespace CodeBase.Infrastructure.States
{
    public class LoadLevelState : IPayloadedState<string>
    {
        private GameStateMachine _gameStateMachine;
        private ISceneLoader _sceneLoader;
        private GameStateMachine _stateMachine;
        private IStaticDataService _staticDataService;
        private IPrefabFactory _prefabFactory;
        private GameObject _ui;
        private ICharacterCustomizator _characterCustomizator;
        private IWindowService _windowService;
        private IMenu _menu;

        [Inject]
        public void Construct(GameStateMachine stateMachine, ISceneLoader sceneLoader,
            IStaticDataService staticDataService, IPrefabFactory prefabFactory,
            ICharacterCustomizator characterCustomizator, IWindowService windowService, IMenu menu)
        {
            _menu = menu;
            _windowService = windowService;
            _characterCustomizator = characterCustomizator;
            _prefabFactory = prefabFactory;
            _staticDataService = staticDataService;
            _stateMachine = stateMachine;
            _sceneLoader = sceneLoader;
        }

        public void Enter(string name)
        {
            _sceneLoader.LoadAsync(name, OnLoaded);
        }

        public void Exit()
        {
        }

        private void OnLoaded()
        {
            LevelData levelData = _staticDataService.LoadResource<LevelData>(PrefabsPath.LevelData);
            CustomizationBase customizationBase = _prefabFactory.CreateCustomizationBase(levelData.CharacterSpawnPoint);
            _characterCustomizator.SetCustomizationBase(customizationBase);
            _windowService.SetCanvas(_prefabFactory.CreateUI());
            _menu.SetCamera(Camera.main.GetComponent<MenuCamera>());
            _menu.OpenMainMenu();
            _stateMachine.Enter<GameLoopState>();
        }
    }
}