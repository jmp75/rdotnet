﻿using RDotNet.Internals;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace RDotNet
{
   /// <summary>
   /// A collection of complex numbers.
   /// </summary>
   [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
   public class ComplexVector : Vector<Complex>
   {
      /// <summary>
      /// Creates a new empty ComplexVector with the specified length.
      /// </summary>
      /// <param name="engine">The <see cref="REngine"/> handling this instance.</param>
      /// <param name="length">The length.</param>
      /// <seealso cref="REngineExtension.CreateComplexVector(REngine, int)"/>
      public ComplexVector(REngine engine, int length)
         : base(engine, SymbolicExpressionType.ComplexVector, length)
      { }

      /// <summary>
      /// Creates a new ComplexVector with the specified values.
      /// </summary>
      /// <param name="engine">The <see cref="REngine"/> handling this instance.</param>
      /// <param name="vector">The values.</param>
      /// <seealso cref="REngineExtension.CreateComplexVector(REngine, System.Collections.Generic.IEnumerable{System.Numerics.Complex})"/>
      public ComplexVector(REngine engine, IEnumerable<Complex> vector)
         : base(engine, SymbolicExpressionType.ComplexVector, vector)
      { }

      /// <summary>
      /// Creates a new instance for a complex number vector.
      /// </summary>
      /// <param name="engine">The <see cref="REngine"/> handling this instance.</param>
      /// <param name="coerced">The pointer to a complex number vector.</param>
      protected internal ComplexVector(REngine engine, IntPtr coerced)
         : base(engine, coerced)
      { }

      /// <summary>
      /// Gets or sets the element at the specified index.
      /// </summary>
      /// <param name="index">The zero-based index of the element to get or set.</param>
      /// <returns>The element at the specified index.</returns>
      public override Complex this[int index]
      {
         get
         {
            if (index < 0 || Length <= index)
            {
               throw new ArgumentOutOfRangeException();
            }
            using (new ProtectedPointer(this))
            {
               var data = new double[2];
               int offset = GetOffset(index);
               IntPtr pointer = IntPtr.Add(DataPointer, offset);
               Marshal.Copy(pointer, data, 0, data.Length);
               return new Complex(data[0], data[1]);
            }
         }
         set
         {
            if (index < 0 || Length <= index)
            {
               throw new ArgumentOutOfRangeException();
            }
            using (new ProtectedPointer(this))
            {
               var data = new[] { value.Real, value.Imaginary };
               int offset = GetOffset(index);
               IntPtr pointer = IntPtr.Add(DataPointer, offset);
               Marshal.Copy(data, 0, pointer, data.Length);
            }
         }
      }

      protected override void SetVectorDirect(Complex[] values)
      {
         double[] data = new double[values.Length];
         for (int i = 0; i < data.Length; i++)
         {
            data[2 * i] = values[i].Real;
            data[2 * i + 1] = values[i].Imaginary;
         }
         IntPtr pointer = IntPtr.Add(DataPointer, 0);
         Marshal.Copy(data, 0, pointer, data.Length);
      }

      /// <summary>
      /// Gets the size of a complex number in byte.
      /// </summary>
      protected override int DataSize
      {
         get { return Marshal.SizeOf(typeof(Complex)); }
      }
   }
}