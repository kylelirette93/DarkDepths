using System;


namespace DarkDepths.States
{
    public class GameState_Upgrade : IState
    {
        #region Singleton
        private static GameState_Upgrade _instance;
        public static GameState_Upgrade Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GameState_Upgrade();
                }
                return _instance;
            }
        }
        #endregion

        // Private constructor to avoid sneaky instantiation.
        private GameState_Upgrade() { }
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
