using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace DarkDepths.Managers
{
    /// <summary>
    /// Asset manager handles loading content. Content can be retrieved from anywhere by accessing it's value from dictionary.
    /// </summary>
    public static class AssetManager
    {
        private static Dictionary<string, Texture2D> textures = new Dictionary<string, Texture2D>();

        public static void LoadContent(ContentManager content)
        {
            if (textures.Count == 0)
            {
                textures["fruitfly"] = content.Load<Texture2D>("Fruitfly_Idle");
            }
        }

        public static Texture2D GetTexture(string name)
        {
            if (textures.TryGetValue(name, out Texture2D tex))
            {
                tex = textures[name];
                return tex;
            }
            throw new System.Exception($"Texture {name} not found.");
        }
    }
}
