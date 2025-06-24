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
        new Coords(40, 90),   // 1
        new Coords(45, 60),   // 2
        new Coords(44, 78),   // 3
        new Coords(47, 42),   // 4
        new Coords(25, 75),   // 5
        new Coords(11, 71),   // 6
        new Coords(-10, 58),  // 7
        new Coords(-26, 29),  // 8
        new Coords(-28, 15), // 9
        new Coords(-34, -23), // 10
        new Coords(-53, -25), // 11
        new Coords(-77, -23), // 12
        new Coords(-80, -10), // 13
        new Coords(-73, 10), // 14
        new Coords(-91, 10)  // 15
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
        Coords.DrawLine(pointArray[0], pointArray[2], 0.5f, Color.white);
        Coords.DrawLine(pointArray[2], pointArray[1], 0.5f, Color.white);
        Coords.DrawLine(pointArray[1], pointArray[3], 0.5f, Color.white);
        Coords.DrawLine(pointArray[2], pointArray[4], 0.5f, Color.white);
        Coords.DrawLine(pointArray[4], pointArray[5], 0.5f, Color.white);
        Coords.DrawLine(pointArray[5], pointArray[6], 0.5f, Color.white);
        Coords.DrawLine(pointArray[6], pointArray[7], 0.5f, Color.white);
        Coords.DrawLine(pointArray[7], pointArray[8], 0.5f, Color.white);
        Coords.DrawLine(pointArray[8], pointArray[9], 0.5f, Color.white);
        Coords.DrawLine(pointArray[9], pointArray[10], 0.5f, Color.white);
        Coords.DrawLine(pointArray[10], pointArray[11], 0.5f, Color.white);
        Coords.DrawLine(pointArray[11], pointArray[12], 0.5f, Color.white);
        Coords.DrawLine(pointArray[12], pointArray[13], 0.5f, Color.white);
        Coords.DrawLine(pointArray[13], pointArray[14], 0.5f, Color.white);
    }
}