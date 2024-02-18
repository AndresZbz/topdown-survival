using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using System.Diagnostics;

namespace IDK2.Classes.Entities
{
    internal class Bullet : Sprite
    {
        private Vector2 dir;
        public Vector2 pos { get; private set; }
        float speed = 10f;
        public Bullet(Texture2D texture, Vector2 position, Vector2 dir) : base(texture, position)
        {
            pos = position;
            this.dir = dir * speed;
        }

        public override void Update(GameTime gametime)
        {
            pos += dir;
            base.Update(gametime);
        }

        public override void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(_texture, pos, Color.White);
        }

    }
}
