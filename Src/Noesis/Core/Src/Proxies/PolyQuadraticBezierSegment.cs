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

namespace Noesis
{

public class PolyQuadraticBezierSegment : PathSegment {
  internal new static PolyQuadraticBezierSegment CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new PolyQuadraticBezierSegment(cPtr, cMemoryOwn);
  }

  internal PolyQuadraticBezierSegment(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(PolyQuadraticBezierSegment obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public PolyQuadraticBezierSegment() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_PolyQuadraticBezierSegment__SWIG_0();
  }

  public PolyQuadraticBezierSegment(ref Point points, uint numPoints, bool isStroked) : this(NoesisGUI_PINVOKE.new_PolyQuadraticBezierSegment__SWIG_1(ref points, numPoints, isStroked), true) {
  }

  public static DependencyProperty PointsProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.PolyQuadraticBezierSegment_PointsProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public PointCollection Points {
    set {
      NoesisGUI_PINVOKE.PolyQuadraticBezierSegment_Points_set(swigCPtr, PointCollection.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.PolyQuadraticBezierSegment_Points_get(swigCPtr);
      return (PointCollection)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

}

}

