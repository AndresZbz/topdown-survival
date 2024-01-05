﻿using IDK2.Classes;
using IDK2.Classes.Entities;
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
    internal class GameState : State
    {
        SpriteFont font;
        Player player;

        Cursor cursor;

        public GameState(Main game, GraphicsDevice graphics, ContentManager content) : base(game, graphics, content)
        {
            
            font = content.Load<SpriteFont>("fonts/File");
            var playerTexture = content.Load<Texture2D>("Sprites/player");

            cursor = new Cursor(playerTexture, Vector2.Zero);
            player = new Player(playerTexture, new Vector2(640, 360));
            
        }

        public override void Draw(GameTime gametime, SpriteBatch spriteBatch)
        {
            

            spriteBatch.Begin();

            player.Draw(spriteBatch);
            cursor.Draw(spriteBatch);

            spriteBatch.End();
        }

        public override void PostUpdate(GameTime gametime)
        {
            //throw new NotImplementedException();
        }

        public override void Update(GameTime gametime)
        {
            
            player.Update(gametime);
            cursor.Update(gametime);
            //throw new NotImplementedException();
        }
    }
}
