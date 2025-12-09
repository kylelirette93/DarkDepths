using System;


namespace DarkDepths.States
{
    public class GameState_MainMenu : IState
    {
        #region Singleton
        private static GameState_MainMenu _instance;
        public static GameState_MainMenu Instance 
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GameState_MainMenu();
                }
                return _instance;
            }
        }
        #endregion

        // Private constructor to avoid sneaky instantiation.
        private GameState_MainMenu() { }

        public void Enter()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Draw()
        {
            throw new NotImplementedException();
        }

        public void Exit()
        {
            throw new NotImplementedException();
        }
    }
}
