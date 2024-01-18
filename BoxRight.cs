
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class BoxRight:Box
{

    public BoxRight(Texture2D texture, Vector2 startPosition)
    :base(texture, startPosition)
    {
        this.texture = texture;
        position=startPosition;
        hitbox = new Rectangle(0, 0, 30,50);
    }

    public override void Update()
    {
        position.X++;
        hitbox.Location = position.ToPoint();

    }

}