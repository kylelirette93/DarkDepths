using Microsoft.Xna.Framework.Input;
using System.Numerics;

namespace DarkDepths.InputSystem
{
    public class InputManager : IInput
    {
        private KeyboardState currentKeyState;
        private KeyboardState previousKeyState;
        public Vector2 MovementDirection
        {
            get
            {
                var direction = Vector2.Zero;
                currentKeyState = Keyboard.GetState();

                if (currentKeyState.IsKeyDown(Keys.W)) direction.Y -= 1;
                if (currentKeyState.IsKeyDown(Keys.S)) direction.Y += 1;
                if (currentKeyState.IsKeyDown(Keys.A)) direction.X -= 1;
                if (currentKeyState.IsKeyDown(Keys.D)) direction.X += 1;

                if (direction != Vector2.Zero) direction = Vector2.Normalize(direction);

                return direction;
            }
        }

        public bool Pause => currentKeyState.IsKeyDown(Keys.Escape) && 
            !previousKeyState.IsKeyDown(Keys.Escape);

        public void Update()
        {
            previousKeyState = currentKeyState;
            currentKeyState = Keyboard.GetState();
        }
    }
}
