
namespace DarkDepths.States
{
    public interface IState
    {
        public void Enter();
        public void Update();
        public void Draw();
        public void Exit();
    }
}
