using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace x46_FW.PFU
{
	public readonly struct Pfloat32
	{
		/// <summary>
		/// the first place maximum value.
		/// </summary>
		public const Int32 Fp_MAX = Int32.MaxValue;

		/// <summary>
		/// the first place minimum value.
		/// </summary>
		public const Int32 Fp_MIN = Int32.MinValue;

		/// <summary>
		/// the decimal places maximum value.
		/// </summary>
		public const UInt32 Dp_MAX = UInt32.MaxValue;

		/// <summary>
		/// the decimal places minimum value.
		/// </summary>
		public const UInt32 Dp_MIN = UInt32.MinValue;

		public override string ToString() => $"{_Fp}.{_Dp}";

		/// <summary>
		/// the first place value.
		/// </summary>
		public Int32 _Fp { get; }

		/// <summary>
		/// the decimal places value.
		/// </summary>
		public UInt32 _Dp { get; }

		public Pfloat32(Int32 X, UInt32 Z)
        {
			_Fp = X;
			_Dp = Z;
        }





	}
}
