using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace x46_FW.PFU
{
	public readonly struct Pfloat16
	{
		/// <summary>
		/// the first place maximum value.
		/// </summary>
		public const Int16 Fp_MAX = Int16.MaxValue;

		/// <summary>
		/// the first place minimum value.
		/// </summary>
		public const Int16 Fp_MIN = Int16.MinValue;

		/// <summary>
		/// the decimal places maximum value.
		/// </summary>
		public const UInt16 Dp_MAX = UInt16.MaxValue;

		/// <summary>
		/// the decimal places minimum value.
		/// </summary>
		public const UInt16 Dp_MIN = UInt16.MinValue;

		public override string ToString() => $"{_Fp}.{_Dp}";

		private float ToFloat()
        {
			float F = _Fp;
			float D = _Dp;
			return 0.0f;
        }

		/// <summary>
		/// the first place value.
		/// </summary>
		public Int16 _Fp { get; }

		/// <summary>
		/// the decimal places value.
		/// </summary>
		public UInt16 _Dp { get; }

		public Pfloat16(Int16 X, UInt16 Z)
		{
			_Fp = X;
			_Dp = Z;
		}
	}
}
