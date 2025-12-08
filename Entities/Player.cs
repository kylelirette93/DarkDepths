
using DarkDepths.InputSystem;
using Microsoft.Xna.Framework;

namespace DarkDepths.Entities;

/// <summary>
/// Player class derrives from base entity. Uses input service to move.
/// </summary>
public class Player : Entity
{
    private IInput input;
    float moveSpeed = 200f;
    public Player(Game1 game) : base(game)
    {
        input = game.Services.GetService<IInput>();
    }

    public override void Update(GameTime gameTime)
    {
        #region Handle Movement
        var movement = input.MovementDirection;
        Position += movement * moveSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
        #endregion
    }

    public override void Draw()
    {
        base.Draw();
    }
}
