
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class BoxLeft
{
    private Texture2D texture;
    private Vector2 position;
    private Rectangle hitbox;

    public BoxLeft(Texture2D texture, Vector2 startPosition)
    {
        this.texture = texture;
        position=startPosition;
        hitbox = new Rectangle(0, 0, 30,50);
    }

    public void Update()
    {
        position.X++;
        hitbox.Location = position.ToPoint();

    }

    public void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(texture,hitbox,Color.Black);
    }



}