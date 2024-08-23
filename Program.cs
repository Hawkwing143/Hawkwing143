string input = "R1, L3, R5, R5, R5, L4, R5, R1, R2, L1, L1, R5, R1, L3, L5, L2, R4, L1, R4, R5, L3, R5, L1, R3, L5, R1, L2, R1, L5, L1, R1, R4, R1, L1, L3, R3, R5, L3, R4, L4, R5, L5, L1, L2, R4, R3, R3, L185, R3, R4, L5, L4, R48, R1, R2, L1, R1, L4, L4, R77, R5, L2, R192, R2, R5, L4, L5, L3, R2, L4, R1, L5, R5, R4, R1, R2, L3, R4, R4, L2, L4, L3, R5, R4, L2, L1, L3, R1, R5, R5, R2, L5, L2, L3, L4, R2, R1, L4, L1, R1, R5, R3, R3, R4, L1, L4, R1, L2, R3, L3, L2, L1, L2, L2, L1, L2, R3, R1, L4, R1, L1, L4, R1, L2, L5, R3, L5, L2, L2, L3, R1, L4, R1, R1, R2, L1, L4, L4, R2, R2, R2, R2, R5, R1, L1, L4, L5, R2, R4, L3, L5, R2, R3, L4, L1, R2, R3, R5, L2, L3, R3, R1, R3";
//input = "R2, R2, R2, R2";
int dir = 0;
int left = 90;
int right = 90;

Vector2 pos = new Vector2(0, 0);

foreach (string instruction in input.Split(", ")) 
{
    if (instruction.StartsWith('R'))
    {
        dir += right;
        if (dir >= 360) dir = 0;
    }
    else if (instruction.StartsWith('L'))
    {
        dir -= left;
        if (dir < 0) dir = 270;
    }
    if (dir == 90)
    { 
        pos.x += int.Parse(instruction.Substring(1));
    }
    else if (dir == 270) 
    {
        pos.x -= int.Parse(instruction.Substring(1));
    }
    if (dir == 0)
    {
        pos.y += int.Parse(instruction.Substring(1));
    }
    else if (dir == 180)
    {
        pos.y -= int.Parse(instruction.Substring(1));
    }
    Console.WriteLine($"{pos.x}, {pos.y}, {dir}");
}

Console.WriteLine(Math.Abs(pos.x) + Math.Abs(pos.y));

struct Vector2 
{
    public int x;
    public int y;
    public Vector2 (int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}