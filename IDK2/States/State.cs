using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDK2.States
{
    public abstract class State
    {
        protected ContentManager _content;

        protected GraphicsDevice _graphic;

        protected Main _game;

        public abstract void Draw(GameTime gametime, SpriteBatch spriteBatch);

        public abstract void PostUpdate(GameTime gametime);

        public State(Main game, GraphicsDevice graphics, ContentManager content)
        {
            _game = game;
            _graphic = graphics;
            _content = content;
        }

        public abstract void Update(GameTime gametime);
    }

        
}
