
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class BoxLeft: Box
{
    private float speed = 1;
    public BoxLeft(Texture2D texture, Vector2 startPosition, float speed = 1)
    : base(texture,startPosition)
    {
        this.speed = speed;
    }

    public override void Update()
    {
        position.X-= speed;
        hitbox.Location = position.ToPoint();

    }

}