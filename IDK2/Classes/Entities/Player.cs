using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDK2.Classes.Entities
{
    internal class Player : Sprite
    {
        private float speed = 500f;
        public Player(Texture2D texture, Vector2 position) : base(texture, position) {
            
        }

        public override void Update(GameTime gametime)
        {
            KeyboardState kstate = Keyboard.GetState();

            if(kstate.IsKeyDown(Keys.D) && _position.X < 1210)
            {
                _position.X += (float)speed * (float)gametime.ElapsedGameTime.TotalSeconds;
            }

            if (kstate.IsKeyDown(Keys.A) && _position.X > 0)
            {
                _position.X += -(float)speed * (float)gametime.ElapsedGameTime.TotalSeconds;
            }

            if (kstate.IsKeyDown(Keys.W) && _position.Y > 0)
            {
                _position.Y += -(float)speed * (float)gametime.ElapsedGameTime.TotalSeconds;
            }

            if (kstate.IsKeyDown(Keys.S) && _position.Y < 650)
            {
                _position.Y += (float)speed * (float)gametime.ElapsedGameTime.TotalSeconds;
            }
        }
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      