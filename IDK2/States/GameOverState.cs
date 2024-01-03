using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDK2.States
{
    internal class GameOverState : State
    {
        public GameOverState(Main game, GraphicsDevice graphics, ContentManager content) : base(game, graphics, content)
        {
        }

        public override void Draw(GameTime gametime, SpriteBatch spriteBatch)
        {
            _graphic.Clear(Color.Blue);
        }

        public override void PostUpdate(GameTime gametime)
        {
            //throw new NotImplementedException();
        }

        public override void Update(GameTime gametime)
        {
            //throw new NotImplementedException();
        }
    }
}
