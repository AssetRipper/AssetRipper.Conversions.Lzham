using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.InlineArrays;

public partial struct InlineArray0_SByte : IEquatable<InlineArray0_SByte>, IEqualityOperators<InlineArray0_SByte, InlineArray0_SByte, bool>, IEnumerable, IInlineArray<InlineArray0_SByte, sbyte>, IInlineArray<InlineArray0_SByte, byte>
{
	public static int Length => 0;

	public static bool operator ==(InlineArray0_SByte x, InlineArray0_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray0_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray0_SByte x, InlineArray0_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray0_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray0_SByte)
		{
			return Equals((InlineArray0_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray0_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
