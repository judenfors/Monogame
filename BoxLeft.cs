
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class BoxLeft: Box
{
    private Texture2D texture;
    private Vector2 position;
    private Rectangle hitbox;

    public BoxLeft(Texture2D texture, Vector2 startPosition): base(texture,startPosition)
    {
    }

    public override void Update()
    {
        position.X--;
        hitbox.Location = position.ToPoint();

    }

    public void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(texture,hitbox,Color.Black);
    }



}