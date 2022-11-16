using System.Collections;
using CodeBase.Services.Data;
using CodeBase.Services.Unity;
using Zenject;

namespace CodeBase.Infrastructure.States
{
    public class GameLoopState : IState
    {
        private int _collectedCoinsAmount;
        private int _coinsAmount;
        private GameStateMachine _gameStateMachine;

        private ICoroutineRunner _coroutineRunner;

        private int _currentTime;

        private IEnumerator _gameCoroutine;
        private IStaticDataService _staticDataService;

        [Inject]
        public void Construct(GameStateMachine gameStateMachine,
            ICoroutineRunner coroutineRunner, IStaticDataService staticDataService)
        {
            _staticDataService = staticDataService;
            _coroutineRunner = coroutineRunner;
            _gameStateMachine = gameStateMachine;
        }

        public void Enter()
        {
        }

        public void Exit()
        {
        }
           
        
    }
}