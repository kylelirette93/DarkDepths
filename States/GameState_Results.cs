using System;


namespace DarkDepths.States
{
    public class GameState_Results : IState
    {
        #region Singleton
        private static GameState_Results _instance;
        public static GameState_Results Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GameState_Results();
                }
                return _instance;
            }
        }
        #endregion

        // Private constructor to avoid sneaky instantiation.
        private GameState_Results() { }
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
