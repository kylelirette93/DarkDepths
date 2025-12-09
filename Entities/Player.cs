
using DarkDepths.InputSystem;
using DarkDepths.EvolutionSystem;
using Microsoft.Xna.Framework;
using DarkDepths.HealthSystem;

namespace DarkDepths.Entities;

/// <summary>
/// Player class derrives from base entity. Uses input service to move.
/// </summary>
public class Player : Entity, IEvolvable
{
    private IInput input;
    private PlayerHealthComponent playerHealth;

    float moveSpeed = 200f;

    public EvolutionType CurrentEvolution { get; private set; }

    public Player(Game1 game) : base(game)
    {
        input = game.Services.GetService<IInput>();
        playerHealth = new PlayerHealthComponent();
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

    public void ApplyEvolution(EvolutionType evolution)
    {
        CurrentEvolution = evolution;
    }
}
