using UnityEngine;

public class ScorpioSign : MonoBehaviour
{
    Coords startPointX = new Coords(-160, 0);
    Coords endPointX = new Coords(160, 0);

    Coords startPointY = new Coords(0, -100);
    Coords endPointY = new Coords(0, 100);

    Coords point = new Coords(0, 0);

    Coords[] pointArray =
    {
        new Coords(40, 90),
        new Coords(45, 60),
        new Coords(44, 78),
        new Coords(47, 42),
        new Coords(25, 75),
        new Coords(11, 71),
        new Coords(-10, 58),
        new Coords(-26, 29),
        new Coords(-28, 30),
        new Coords(-34, -23),
        new Coords(-53, -25),
        new Coords(-77, -23),
        new Coords(-87, -78),
        new Coords(-73, 90),
        new Coords(-91, 10) 
    };

    void Start()
    {
        Coords.DrawPoint(point, 2, Color.white);
        Coords.DrawLine(startPointX, endPointX, 1, Color.red);
        Coords.DrawLine(startPointY, endPointY, 1, Color.green);

        foreach (var p in pointArray)
        {
            Coords.DrawPoint(p, 2, Color.white);
        }
        
    }
}