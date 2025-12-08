using DarkDepths.RendererSystem;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;


namespace DarkDepths.Entities
{
    /// <summary>
    /// Entity base class, has a texture and position.
    /// </summary>
    public class Entity
    {
        private IRenderer renderer;
        public Texture2D Texture { get; set; }
        public Vector2 Position { get; set; }

        public Entity(Game1 game)
        {
            renderer = game.Services.GetService<IRenderer>();
        }

        public virtual void Update(GameTime gameTime)
        {
  
        }

        public virtual void Draw()
        {
            renderer.DrawSprite(Texture, Position, Color.White);
        }
    }
}
