using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace IDK2.Classes.UI
{
    public class Button : Component
    {
        private MouseState currentMouse;
        private SpriteFont _font;

        private bool isHover;
        private MouseState previousMouse;

        private Texture2D _texture;

        public event EventHandler Click;

        public bool Clicked { get; private set; }

        public Color PenColour { get; set; }

        public Vector2 Position { get; set; }

        public Rectangle Rectangle
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, _texture.Width, _texture.Height);
            }
        }

        public String text { get; set; }

        public Button(Texture2D texture, SpriteFont font)
        {
            _texture = texture;
            _font = font;
            PenColour = Color.White;
        }

        public override void Draw(GameTime gametime, SpriteBatch spritebatch)
        {
            var col = Color.White;

            if (isHover)
            {
                col = Color.Gray;
            }

            spritebatch.Draw(_texture, Rectangle, col);

            if (!string.IsNullOrEmpty(text))
            {
                var x = (Rectangle.X + (Rectangle.Width / 2)) - (_font.MeasureString(text).X / 2);
                var y = (Rectangle.Y + (Rectangle.Height / 2)) - (_font.MeasureString(text).Y / 2);

                spritebatch.DrawString(_font, text, new Vector2(x, y), PenColour);
            }
        }

        public override void Update(GameTime gameTime)
        {
            previousMouse = currentMouse;
            currentMouse = Mouse.GetState();

            var mouseRectangle = new Rectangle(currentMouse.X, currentMouse.Y, 1, 1);

            isHover = false;

            if (mouseRectangle.Intersects(Rectangle))
            {
                isHover = true;

                if (currentMouse.LeftButton == ButtonState.Released && previousMouse.LeftButton == ButtonState.Pressed)
                {
                    Click?.Invoke(this, new EventArgs());
                }
            }
        }
    }
}
