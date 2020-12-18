using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace x46_FW.PFU
{
	public readonly struct Pfloat64
	{
		/// <summary>
		/// the first place maximum value.
		/// </summary>
		public const Int64 Fp_MAX = Int64.MaxValue;

		/// <summary>
		/// the first place minimum value.
		/// </summary>
		public const Int64 Fp_MIN = Int64.MinValue;

		/// <summary>
		/// the decimal places maximum value.
		/// </summary>
		public const UInt64 Dp_MAX = UInt64.MaxValue;

		/// <summary>
		/// the decimal places minimum value.
		/// </summary>
		public const UInt64 Dp_MIN = UInt64.MinValue;

		public override string ToString() => $"{_Fp}.{_Dp}";

		/// <summary>
		/// the first place value.
		/// </summary>
		public Int64 _Fp { get; }

		/// <summary>
		/// the decimal places value.
		/// </summary>
		public UInt64 _Dp { get; }

		public Pfloat64(Int64 X, UInt64 Z)
        {
			_Fp = X;
			_Dp = Z;
        }





	}
}
