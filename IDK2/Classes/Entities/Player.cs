using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Graphics.PackedVector;
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
        private int speed = 500;
        Vector2 origin { get; set; }
        int rotation;
        public Player(Texture2D texture, Vector2 position) : base(texture, position) {



            origin = new Vector2(_texture.Width / 2, _texture.Height / 2);
            
        }

        public override void Update(GameTime gametime)
        {
            KeyboardState kstate = Keyboard.GetState();
            Vector2 movement = Vector2.Zero;
            MouseState mouseState = Mouse.GetState();


            rotation = mouseState.X;

            if (kstate.IsKeyDown(Keys.D) && _position.X < 1242)
            {
                movement.X += 1;
            }

            if (kstate.IsKeyDown(Keys.A) && _position.X > 32)
            {
                movement.X -= 1;
            }

            if (kstate.IsKeyDown(Keys.W) && _position.Y > 32)
            {
                movement.Y -= 1;
            }

            if (kstate.IsKeyDown(Keys.S) && _position.Y < 680)
            {
                movement.Y += 1;
            }

            if(movement != Vector2.Zero)
            {
                movement.Normalize();

                _position += movement * speed * (float)gametime.ElapsedGameTime.TotalSeconds;
            }
        }

        public override void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(_texture, _position, null, Color.White, 0f, origin, 1f, SpriteEffects.None, 1f);
        }
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      