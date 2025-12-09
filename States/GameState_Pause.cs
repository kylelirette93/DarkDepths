using System;


namespace DarkDepths.States
{
    public class GameState_Pause : IState
    {
        #region Singleton
        private static GameState_Pause _instance;
        public static GameState_Pause Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GameState_Pause();
                }
                return _instance;
            }
        }
        #endregion

        // Private constructor to avoid sneaky instantiation.
        private GameState_Pause() { }
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
