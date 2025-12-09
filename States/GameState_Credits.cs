using System;


namespace DarkDepths.States
{
    public class GameState_Credits : IState
    {
        #region Singleton
        private static GameState_Credits _instance;
        public static GameState_Credits Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GameState_Credits();
                }
                return _instance;
            }
        }
        #endregion

        // Private constructor to avoid sneaky instantiation.
        private GameState_Credits() { }
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
