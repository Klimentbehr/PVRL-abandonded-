public class Enemy
{
    public Point Position { get; set; }
    public int Health { get; set; }
    public int AttackRange { get; set; }
    public int Damage { get; set; }

    public Enemy(Point position, int health, int attackRange, int damage)
    {
        Position = position;
        Health = health;
        AttackRange = attackRange;
        Damage = damage;
    }

    public void MoveRandomly(string[] mapLines)
    {
        Random random = new Random();
        int dx = 0, dy = 0;

        switch (random.Next(4))
        {
            case 0: dx = -1; break; // Move left
            case 1: dx = 1; break;  // Move right
            case 2: dy = -1; break; // Move up
            case 3: dy = 1; break;  // Move down
        }

        int newX = Position.X + dx;
        int newY = Position.Y + dy;

        if (newX >= 0 && newX < mapLines[0].Length && newY >= 0 && newY < mapLines.Length)
        {
            if (mapLines[newY][newX] != '#' && mapLines[newY][newX] != 'P')
            {
                Position = new Point(newX, newY);
            }
        }
    }
}

