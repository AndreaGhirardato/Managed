//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Noesis
{

[StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
public struct Vector3D {

  [MarshalAs(UnmanagedType.R4)]
  private float _x;

  [MarshalAs(UnmanagedType.R4)]
  private float _y;

  [MarshalAs(UnmanagedType.R4)]
  private float _z;

  public float X {
    get { return this._x; }
    set { this._x = value; }
  }

  public float Y {
    get { return this._y; }
    set { this._y = value; }
  }

  public float Z {
    get { return this._z; }
    set { this._z = value; }
  }

  public Vector3D(float x, float y, float z) {
    this._x = x;
    this._y = y;
    this._z = z;
  }

  public float Length {
    get { return (float)Math.Sqrt(LengthSquared); }
  }

  public float LengthSquared {
    get { return this._x * this._x + this._y * this._y + this._z * this._z; }
  }

  public void Normalize() {
    this /= this.Length;
  }

  public static Vector3D CrossProduct(Vector3D v0, Vector3D v1) {
    return new Vector3D(
      v0._y * v1._z - v0._z * v1._y,
      v0._z * v1._x - v0._x * v1._z,
      v0._x * v1._y - v0._y * v1._x);
  }

  public static Vector3D operator-(Vector3D vector) {
    return new Vector3D(-vector._x, -vector._y, -vector._z);
  }

  public void Negate() {
    _x = -_x;
    _y = -_y;
    _z = -_z;
  }

  public static Vector3D operator+(Vector3D v0, Vector3D v1) {
    return new Vector3D(v0._x + v1._x, v0._y + v1._y, v0._z + v1._z);
  }

  public static Vector3D Add(Vector3D v0, Vector3D v1) {
    return new Vector3D(v0._x + v1._x, v0._y + v1._y, v0._z + v1._z);
  }

  public static Vector3D operator-(Vector3D v0, Vector3D v1) {
    return new Vector3D(v0._x - v1._x, v0._y - v1._y, v0._z - v1._z);
  }

  public static Vector3D Subtract(Vector3D v0, Vector3D v1) {
    return new Vector3D(v0._x - v1._x, v0._y - v1._y, v0._z - v1._z);
  }

  public static Point3D operator+(Vector3D vector, Point3D point) {
    return new Point3D(point.X + vector._x, point.Y + vector._y, point.Z + vector._z);
  }

  public static Point3D Add(Vector3D vector, Point3D point) {
    return new Point3D(point.X + vector._x, point.Y + vector._y, point.Z + vector._z);
  }

  public static Vector3D operator*(Vector3D vector, float scalar) {
    return new Vector3D(vector._x * scalar, vector._y * scalar, vector._z * scalar);
  }

  public static Vector3D Multiply(Vector3D vector, float scalar) {
    return new Vector3D(vector._x * scalar, vector._y * scalar, vector._z * scalar);
  }

  public static Vector3D operator*(float scalar, Vector3D vector) {
    return new Vector3D(vector._x * scalar, vector._y * scalar, vector._z * scalar);
  }

  public static Vector3D Multiply(float scalar, Vector3D vector) {
    return new Vector3D(vector._x * scalar, vector._y * scalar, vector._z * scalar);
  }

  public static Vector3D operator/(Vector3D vector, float scalar) {
    return vector * (1.0f / scalar);
  }

  public static Vector3D Divide(Vector3D vector, float scalar) {
    return vector * (1.0f / scalar);
  }

  public static float operator*(Vector3D v0, Vector3D v1) {
    return v0._x * v1._x + v0._y * v1._y + v0._z * v1._z;
  }

  public static float Multiply(Vector3D v0, Vector3D v1) {
    return v0._x * v1._x + v0._y * v1._y + v0._z * v1._z;
  }

  public static explicit operator Point3D(Vector3D vector) {
    return new Point3D(vector._x, vector._y, vector._z);
  }

  public static bool operator==(Vector3D v0, Vector3D v1) {
    return v0._x == v1._x && v0._y == v1._y && v0._z == v1._z;
  }

  public static bool operator!=(Vector3D v0, Vector3D v1) {
    return !(v0 == v1);
  }

  public static bool Equals(Vector3D v0, Vector3D v1) {
    return v0 == v1;
  }

  public override bool Equals(object o) {
    return o is Vector3D && this == (Vector3D)o;
  }

  public bool Equals(Vector3D value) {
    return Vector3D.Equals(this, value);
  }

  public override int GetHashCode() {
    return this.X.GetHashCode() ^ this.Y.GetHashCode() ^ this.Z.GetHashCode();
  }

  public override string ToString() {
    return String.Format("{0},{1},{2}", X, Y, Z);
  }

  public static Vector3D Parse(string str) {
    Match match = sRegex.Match(str);
    if (match.Success) {
      float x = float.Parse(match.Groups[1].Value, CultureInfo.InvariantCulture);
      float y = float.Parse(match.Groups[2].Value, CultureInfo.InvariantCulture);
      float z = float.Parse(match.Groups[3].Value, CultureInfo.InvariantCulture);
      return new Vector3D(x, y, z);
    }
    throw new ArgumentException("Cannot create Vector3D from '" + str + "'");
  }

  private static string sParseExpression = @"\s*(.*[^,\s])\s*[,\s]\s*(.*[^,\s])\s*[,\s]\s*(.*[^,\s])\s*";
  private static Regex sRegex = new Regex(sParseExpression);

}

}

