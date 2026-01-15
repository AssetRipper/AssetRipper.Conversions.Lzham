using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.InlineArrays;

[InlineArray(66)]
public partial struct InlineArray66_SByte : IEquatable<InlineArray66_SByte>, IEqualityOperators<InlineArray66_SByte, InlineArray66_SByte, bool>, IEnumerable, IInlineArray<InlineArray66_SByte, sbyte>, IInlineArray<InlineArray66_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 66;

	public static bool operator ==(InlineArray66_SByte x, InlineArray66_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray66_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray66_SByte x, InlineArray66_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray66_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray66_SByte)
		{
			return Equals((InlineArray66_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray66_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
