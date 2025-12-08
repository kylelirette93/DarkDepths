using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;


namespace DarkDepths.RendererSystem
{
    /// <summary>
    /// IRenderer enforces draw methods, it's implemented by renderer service.
    /// </summary>
    internal interface IRenderer
    {
        void BeginDraw();
        void EndDraw();
        void DrawSprite(Texture2D texture, Vector2 position, Color color);
        SpriteBatch SpriteBatch { get; }
    }

    /// <summary>
    /// Renderer service handles sprite batch drawing.
    /// </summary>
    public class Renderer : IRenderer
    {
        public SpriteBatch SpriteBatch { get; private set; }

        public Renderer(GraphicsDevice graphicsDevice)
        {
            SpriteBatch = new SpriteBatch(graphicsDevice);
        }

        public void BeginDraw()
        {
            SpriteBatch.Begin();
        }

        public void EndDraw()
        {
            SpriteBatch.End();
        }

        public void DrawSprite(Texture2D texture, Vector2 position, Color color)
        {
            SpriteBatch.Draw(texture, position, color);
        }
    }

}
