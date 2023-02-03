using System.Collections.Generic;
using UnityEngine;

public static class D_Utilities
{
    /// <summary>Return range from value n which acts in range start1 to stop1 to new range</summary>
    /// <param name="n">the source value to map</param>
    /// <param name="start1">the lowest value the source can have</param>
    /// <param name="stop1">the highest value the source can have</param>
    /// <param name="start2">the lower border the new value has</param>
    /// <param name="stop2">the higher border the new value has</param>
    /// <returns>the new value maped to the source value</returns>
    public static float MapRange(float n, float start1, float stop1, float start2, float stop2) 
    {
        float newval = (n - start1) / (stop1 - start1) * (stop2 - start2) + start2;
        if (start2 < stop2) 
            return Mathf.Clamp(newval, start2, stop2);
        else 
            return Mathf.Clamp(newval, stop2, start2);
    }


    /// <summary>rounds a value to a set decimals</summary>
    /// <param name="v">value to round</param>
    /// <param name="dec">number of decimal places to round to</param>
    /// <returns>rounded number</returns>
    public static float RoundTo(float v, float dec) 
    {
        return Mathf.Floor(v*Mathf.Pow(10,dec))/Mathf.Pow(10,dec);
    }


    /// <summary>Adds a value to all axis of the given vector</summary>
    /// <param name="v">vector to add to</param>
    /// <param name="adding">value to add</param>
    /// <returns>new vector added up by adding</returns>
    public static Vector3 AddVec3(Vector3 v, float adding) 
    {
        return new Vector3(v.x + adding, v.y + adding, v.z + adding);
    }


    //? why this? it works with -> v += new Vector3(0,0,1);
    /* 
    /// <summary></summary>
    /// <param name=""></param>
    /// <param name=""></param>
    /// <returns></returns>
    public static Vector3 AddToAxis(Vector3 v, Vector3 add)
    {
        return new Vector3(v.x + add.x, v.y + add.y, v.z + add.z);
    } */


    /// <summary>subtract a value if all axis of the given vector</summary>
    /// <param name="v">vector to subtract from</param>
    /// <param name="substrac">value to substrac</param>
    /// <returns>new vector subtracted by value</returns>
    public static Vector3 SubVec3(Vector3 v, float substrac)
    {
        return new Vector3(v.x - substrac, v.y - substrac, v.z - substrac);
    }


    /// <summary>Rounds the given vector to a set decimal</summary>
    /// <param name="v">vector to round</param>
    /// <param name="dec">the number of decimal places to round to</param>
    /// <returns>new rounded vector</returns>
    public static Vector3 RndVec3(Vector3 v, int dec)
    {
        return new Vector3(
            Mathf.Round(v.x * Mathf.Pow(10,dec)) / Mathf.Pow(10,dec),
            Mathf.Round(v.y * Mathf.Pow(10,dec)) / Mathf.Pow(10,dec),
            Mathf.Round(v.z * Mathf.Pow(10,dec)) / Mathf.Pow(10,dec));
    }


    /// <summary>Return the absolute of v</summary>
    /// <typeparam name="Vector3">Vector3 elemt type.</typeparam>
    /// <param name="v">vector</param>
    /// <returns>new absolute vector</returns>
    public static Vector3 AbsVec(Vector3 v)
    {
        return new Vector3(Mathf.Abs(v.x), Mathf.Abs(v.y), Mathf.Abs(v.z));
    }


    /// <summary>Set the y-Axis of v to 0</summary>
    /// <param name="v">vector to edit</param>
    /// <param name="newY">new y-Value</param>
    /// <returns>new vector</returns>
    public static Vector3 SetYAxis(Vector3 v, float newY)
    {
        return new Vector3(v.x, newY, v.z);
    }


    /// <summary>Replace any value that's not 0</summary>
    /// <param name="v">current vector</param>
    /// <param name="axis">vector with new values to exchange</param>
    /// <returns>new vector</returns>
    public static Vector3 SetAxis(Vector3 v, Vector3 axis)
    {
        float x = axis.x != 0 ? axis.x : v.x;
        float y = axis.y != 0 ? axis.y : v.y;
        float z = axis.z != 0 ? axis.z : v.z;
        return new Vector3(x,y,z);
    }


    /// <summary>Optimized Version of Vector3.Distance</summary>
    /// <param name="current Position">Postiion 1</param>
    /// <param name="target Position">Position 2</param>
    /// <returns>The distance between the two points</returns>
    public static float DDistance(Vector3 currentPosition, Vector3 targetPosition)
    {
        float xD = targetPosition.x - currentPosition.x;
        float yD = targetPosition.y - currentPosition.y;
        float zD = targetPosition.z - currentPosition.z;
        float dist2 = xD*xD + yD*yD + zD*zD; // or xD*xD + zD*zD
        return Mathf.Sqrt(dist2);
    }


    /// <summary>
    /// Shuffle the array. Fisher–Yates shuffle?
    /// </summary> 
    /// <typeparam name="T">Array element type.</typeparam>
    /// <param name="array">Array to shuffle.</param>
    public static void Shuffle<T>(T[] array)
    {
        int n = array.Length;
        for (int i = 0; i < (n - 1); i++)
        {
            int r = i + Random.Range(0,n - i);
            T t = array[r];
            array[r] = array[i];
            array[i] = t;
        }
    }


    public static string GetEnumerableString<T>(IEnumerable<T> items)
    {
        string values = "Values: ";
        foreach (var item in items)
        {
            values += item + ", ";
        }

        /* foreach (var item in items)
        {
            values += "\n - " + item);
        } */

        return values;
    }

}

/*
    

*/