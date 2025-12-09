using DarkDepths.States;

namespace DarkDepths.Managers
{
    public class GameStateManager
    {
        private IState _currentState;
        private IState _lastState;

        private GameState_MainMenu GameState_MainMenu = GameState_MainMenu.Instance;
        private GameState_Gameplay GameState_Gameplay = GameState_Gameplay.Instance;
        private GameState_Pause GameState_Pause = GameState_Pause.Instance;
        private GameState_Credits GameState_Credits = GameState_Credits.Instance;
        private GameState_Results GameState_Results = GameState_Results.Instance;
        private GameState_Upgrade GameState_Upgrade = GameState_Upgrade.Instance;

        void Initialize()
        {
            // Start in main menu.
            _currentState = GameState_MainMenu;
            _currentState.Enter();
        }

        public void SwitchToState(IState newState)
        {
            if (_currentState != null)
            {
                _currentState.Exit();
                _lastState = _currentState;
            }
            _currentState = newState;
            _currentState.Enter();
        }
 
        public void Update()
        {
            _currentState?.Update();
        }
        
        public void Draw()
        {
            _currentState?.Draw();
        }
    }

    public enum GameState
    {
        MainMenu,
        Gameplay,
        Pause,
        Credits,
        Results,
        Upgrade
    }
}
