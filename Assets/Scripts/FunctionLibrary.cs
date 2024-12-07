using System.Runtime.InteropServices.WindowsRuntime;
using TMPro;
using UnityEngine;
using static UnityEngine.Mathf;
class FunctionLibrary
{
    public delegate Vector3 Function(float u,float v, float t);

    public enum FunctionName { Wave, MultiWave, Ripple, Sphere, Torus};

    static Function[] functions = {Wave, MultiWave, Ripple, Sphere, Torus};
    public static Vector3 Wave(float u,float v, float t)
    {
        Vector3 p;
        p.x = u;
        p.y = Sin(PI * (u + v + t));
        p.z = v;
        return p;
    }

    public static Vector3 MultiWave(float u,float v, float t)
    {
        Vector3 p;
        p.x = u;
        float y = Sin(PI * (u + 0.5f * t));
        y += Sin(2f * PI * (v + t)) * 0.5f;
        y += Sin(PI * (u + v + 0.25f * t));
        p.y = y;
        p.y *= (1f / 2.5f);
        p.z = v;
        return p;
    }

    public static Vector3 Ripple(float u,float v, float t)
    {
        Vector3 p; 
        p.x = u;
        float d = Sqrt(u * u + v * v);
        p.y = Sin(PI * (4f * d - t));
        p.y /= (1f + 10f * d);
        p.z = v;
        return p;
    }

    public static Vector3 Sphere(float u, float v, float t)
    {
        Vector3 p;
        float r = 0.9f + 0.1f * Sin(PI * (6f * u + 4f * v + t));
        float s = r * Cos(0.5f * PI * v);
        p.x = s * Sin(PI * u);
        p.y = r * Sin(0.5f * PI * v);
        p.z = s * Cos(PI * u);
        return p;
    }

    public static Vector3 Torus(float u, float v, float t)
    {
        Vector3 p;
        float r1 = 0.7f + 0.1f * Sin(PI * (6f * u + 0.5f * t));
        float r2 = 0.15f + 0.05f * Sin(PI * (8f * u + 4f * v + 2f * t));
        float s = r1 + r2 * Cos(PI * v);
        p.x = s * Sin(PI * u);
        p.y = r2 * Sin(PI * v);
        p.z = s * Cos(PI * u);
        return p;
    }

   /* public static Vector3 MobiusStrip(float u, float v, float t)
    {
        Vector3 p;
        float m = (1f + (0.5f * v) * Cos(0.5f * u));
        p.x = m * Cos(u);
        p.y = (0.5f * v) * Sin(0.5f * u);
        p.z = m * Sin(u);
        return p;
    }*/




    /*public static Vector3 Helix(float u, float v, float t)
    {
        Vector3 p;
        float r = 1f;
        float h = 1f;
        p.x = r * Cos(u +t);
        p.y = h * u;
        p.z = r * Sin(u +t);
        return p;
    }*/

    public static Function GetFunction(FunctionName name)
    {
        return functions[(int)name];
    }

    public static FunctionName GetNextFunction(FunctionName name)
    {
        return (int)name < functions.Length - 1 ?  name + 1 : 0;  
    }

    public static FunctionName GetNextFunctionRandom(FunctionName name)
    {
        var choice = (FunctionName)Random.Range(1, functions.Length);
        return choice == name ? 0 : choice;
    }

    public static Vector3 Morph(float u, float v, float t,Function from,Function to,float progress)
    {
        return Vector3.LerpUnclamped(from(u, v, t), to(u, v, t), SmoothStep(0f, 1f, progress));
    }
}