using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Graphics.PackedVector;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDK2.Classes.Entities
{
    internal class Player : Sprite
    {
        public List<Bullet> bullets;
        public Texture2D bulletTexture;

        private int speed = 500;
        Vector2 origin { get; set; }
        int rotation;

        private MouseState prev;
        public Player(Texture2D texture, Vector2 position, Texture2D bulletTexture) : base(texture, position)
        {
            origin = new Vector2(_texture.Width / 2, _texture.Height / 2);
            bullets = new List<Bullet>();
            this.bulletTexture = bulletTexture;
        }

        public override void Update(GameTime gametime)
        {
            KeyboardState kstate = Keyboard.GetState();
            Vector2 movement = Vector2.Zero;
            MouseState mouseState = Mouse.GetState();


            rotation = mouseState.X;

            if (kstate.IsKeyDown(Keys.D) && _position.X < 1242)
                movement.X += 1;

            if (kstate.IsKeyDown(Keys.A) && _position.X > 32)
                movement.X -= 1;

            if (kstate.IsKeyDown(Keys.W) && _position.Y > 32)
                movement.Y -= 1;

            if (kstate.IsKeyDown(Keys.S) && _position.Y < 680)
                movement.Y += 1;

            if(movement != Vector2.Zero)
            {
                movement.Normalize();

                _position += movement * speed * (float)gametime.ElapsedGameTime.TotalSeconds;
            }

            if(mouseState.LeftButton == ButtonState.Pressed && prev.LeftButton == ButtonState.Released)
            {
                shoot(mouseState.Position.ToVector2());
                Debug.WriteLine("shoot!");
            }
            prev = mouseState;

            foreach(Bullet bullet in bullets)
            {
                bullet.Update(gametime);
            }

            for(int i = bullets.Count - 1; i >= 0; i--)
            {
                bullets[i].Update(gametime);
                if (bullets[i].pos.X < 0 || bullets[i].pos.X > 1280 ||
                    bullets[i].pos.Y < 0 || bullets[i].pos.Y > 720)
                {
                    bullets.Remove(bullets[i]);
                }
            }
        }

        public override void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(_texture, _position, null, Color.White, 0f, origin, 1f, SpriteEffects.None, 1f);

            foreach(Bullet bullet in bullets)
            {
                bullet.Draw(spritebatch);
            }
        }

        private void shoot(Vector2 target)
        {
            Vector2 dir = Vector2.Normalize(target - _position);
            Bullet bullet = new Bullet(bulletTexture, _position, dir);

            bullets.Add(bullet);
        }
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      