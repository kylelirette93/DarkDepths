using System;


namespace DarkDepths.States
{
    public class GameState_Gameplay : IState
    {
        #region Singleton
        private static GameState_Gameplay _instance;
        public static GameState_Gameplay Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GameState_Gameplay();
                }
                return _instance;
            }
        }
        #endregion

        // Private constructor to avoid sneaky instantiation.
        private GameState_Gameplay() { }
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
