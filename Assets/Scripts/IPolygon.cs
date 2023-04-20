using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPolygon
{

    int ID { get; }
    int Width { get; }
    int Height { get; }
    int Rotation { get; }
    decimal[] Center { get; }
    decimal[,] Vertices { get; }

    void Move(decimal centerDeltaX, decimal centerDeltaY);
    void Rotate(int angle);
}
