using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class HexMetrics
{
    //Completed using the CatLikeCoding Hex Map tutorial
    //https://catlikecoding.com/unity/tutorials/hex-map/part-1/

    //Outer radius of hex is circumscribed around the points
    public const float outerRadius = 10f;

    //Inner radius is circumscribed inside of edges and is sqrt(3)/2 * outer radius
    public const float innerRadius = outerRadius * 0.866025404f;

    //Details location of corners relative to center of hexagon with point top hex
    public static Vector3[] corners = {
        new Vector3(0f, 0f, outerRadius),
        new Vector3(innerRadius, 0f, 0.5f * outerRadius),
        new Vector3(innerRadius, 0f, -0.5f * outerRadius),
        new Vector3(0f, 0f, -outerRadius),
        new Vector3(-innerRadius, 0f, -0.5f * outerRadius),
        new Vector3(-innerRadius, 0f, 0.5f * outerRadius)
    };
}
