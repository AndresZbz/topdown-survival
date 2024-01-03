using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDK2.Classes.Entities
{
    internal class Sprite
    {
        public Texture2D _texture;
        public Vector2 _position;

        public Sprite(Texture2D texture, Vector2 position)
        {
            _texture = texture;
            _position = position;
        }

        public virtual void Update(GameTime gametime)
        {

        }

        public virtual void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(_texture, _position, Color.White);
        }
    }
}
