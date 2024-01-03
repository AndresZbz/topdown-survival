using IDK2.Classes;
using IDK2.Classes.UI;
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
    internal class OptionState : State
    {
        private List<Component> components;
        public OptionState(Main game, GraphicsDevice graphics, ContentManager content) : base(game, graphics, content)
        {

            var btnTexture = content.Load<Texture2D>("components/Button");
            var btnFont = content.Load<SpriteFont>("fonts/File");

            var goBack = new Button(btnTexture, btnFont)
            {
                Position = new Vector2(1280 / 2.2f, 720 / 2.2f),
                text = "Back",
            };

            goBack.Click += GoBack;

            components = new List<Component>()
            {
                goBack,
            };
        }

        public override void Draw(GameTime gametime, SpriteBatch spriteBatch)
        {
            _graphic.Clear(Color.Black);

            spriteBatch.Begin();

            foreach (var component in components)
            {
                component.Draw(gametime, spriteBatch);
            }

            spriteBatch.End();
        }

        public override void PostUpdate(GameTime gametime)
        {
            //throw new NotImplementedException();
        }

        public override void Update(GameTime gametime)
        {
            //throw new NotImplementedException();

            foreach (var component in components)
            {
                component.Update(gametime);
            }
        }

        public void GoBack(object sender, EventArgs e)
        {
            _game.ChangeState(new MenuState(_game, _graphic, _content));
        }
    }
}
