using IDK2.Classes;
using IDK2.Classes.UI;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDK2.States
{
    internal class MenuState : State
    {

        private List<Component> components;
        public MenuState(Main game, GraphicsDevice graphics, ContentManager content) : base(game, graphics, content)
        {
            var btnTexture = content.Load<Texture2D>("components/Button");
            var btnFont = content.Load<SpriteFont>("fonts/File");

            var newGame = new Button(btnTexture, btnFont)
            {
                Position = new Vector2(1280 / 2.2f, 720 / 3.2f),
                text = "New Game",
            };

            var optionsGame = new Button(btnTexture, btnFont)
            {
                Position = new Vector2(1280 / 2.2f, 720 / 2.2f),
                text = "Options",
            };

            var quitGame = new Button(btnTexture, btnFont)
            {
                Position = new Vector2(1280 / 2.2f, 720 / 1.2f),
                text = "Exit",
            };

            newGame.Click += NewGameState;
            optionsGame.Click += OptionState;
            quitGame.Click += QuitGame;

            components = new List<Component>()
            {
                newGame,
                optionsGame,
                quitGame,
            };
        }

        public override void Draw(GameTime gametime, SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();

            foreach (var component in components)
            {
                component.Draw(gametime, spriteBatch);
            }

            spriteBatch.End();
        }

        private void NewGameState(object sender, EventArgs e)
        {
            _game.ChangeState(new GameState(_game, _graphic, _content));
        }

        private void OptionState(object sender, EventArgs e)
        {
            _game.ChangeState(new OptionState(_game, _graphic, _content));
        }

        private void QuitGame(object sender, EventArgs e)
        {
            _game.Exit();
        }

        public override void PostUpdate(GameTime gametime)
        {
            //throw new NotImplementedException();
        }

        public override void Update(GameTime gametime)
        {
            foreach (var component in components)
            {
                component.Update(gametime);
            } 
            //throw new NotImplementedException();
        }
    }
}
