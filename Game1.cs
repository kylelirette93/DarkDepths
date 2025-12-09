using DarkDepths.Factory;
using DarkDepths.InputSystem;
using DarkDepths.Managers;
using DarkDepths.RendererSystem;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace DarkDepths
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private IRenderer _renderer; // Renderer service for easy drawing.
        private EntityFactory _gameObjectFactory; // Factory for easy entity creation.
        private GameStateManager _gameStateManager;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            _gameObjectFactory = new EntityFactory(this);
            #region Initialize Services
            var inputManager = new InputManager();
            _renderer = new Renderer(GraphicsDevice);
            _gameStateManager = new GameStateManager();
            Services.AddService<IRenderer>(_renderer);
            Services.AddService(_gameStateManager);
            Services.AddService<IInput>(inputManager);
            #endregion
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            // TODO: use this.Content to load your game content here
            AssetManager.LoadContent(Content);

            // TODO: Move to scene class eventually, but for testing here it is.
            _gameObjectFactory.CreatePlayer();
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            #region Update Calls
            // TODO: Add your update logic here
            var input = Services.GetService<IInput>();
            input.Update();

            _gameObjectFactory.UpdateEntities(gameTime);
            #endregion

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            #region Draw Calls
            _renderer.BeginDraw();

            _gameObjectFactory.DrawEntities();

            _renderer.EndDraw();
            #endregion
            base.Draw(gameTime);
        }
    }
}
