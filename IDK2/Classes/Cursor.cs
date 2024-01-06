using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using IDK2.Classes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mime;

namespace IDK2.Classes
{
    internal class Cursor : Sprite
    {
        private Texture2D _texture;
        Vector2 origin { get; set; }

        public Cursor(Texture2D texture, Vector2 position) : base(texture, position)
        {
            _texture = texture;

            origin = new Vector2(_texture.Width / 2, _texture.Height / 2);
        }

        public override void Update(GameTime gametime)
        {
            MouseState mouseState = Mouse.GetState();

            _position = new Vector2(mouseState.X, mouseState.Y);
        }

        public override void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(_texture, _position, null, Color.White, 0f, origin, 2f, SpriteEffects.None, 1f);
        }

    }
}
