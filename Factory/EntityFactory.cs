using DarkDepths.Entities;
using DarkDepths.Managers;
using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace DarkDepths.Factory
{
    /// <summary>
    /// Game Object Factory handles creation of entities.
    /// </summary>
    public class EntityFactory
    {
        Game1 _game1;
        List<Entity> _entities = new List<Entity>();
        public EntityFactory(Game1 game)
        {
            _game1 = game;
        }

        public void CreatePlayer()
        {
            var player = new Player(_game1);
            player.Texture = AssetManager.GetTexture("player");
            player.Position = new Vector2(400, 400);
            _entities.Add(player);
        }

        public void UpdateEntities(GameTime gameTime)
        {
            foreach (var entity in _entities)
            {
                entity.Update(gameTime);
            }
        }

        public void DrawEntities()
        {
            foreach (var entity in _entities)
            {
                entity.Draw();
            }
        }
    }
}
