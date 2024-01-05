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
        public Vector2 anchor_point = new Vector2(640, 360);
        Vector2 origin { get; set; }

        public Sprite(Texture2D texture, Vector2 position)
        {
            _texture = texture;
            _position = position;


            //this sets the anchor point of the sprite to the middle
            origin = new Vector2(_texture.Width / 2, _texture.Height / 2); 
        }

        public virtual void Update(GameTime gametime)
        {

        }

        public virtual void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(_texture, _position, null, Color.White, 0f, origin, 1f, SpriteEffects.None, 0f);
        }
    }
}
