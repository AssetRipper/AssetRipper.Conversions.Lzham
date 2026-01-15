using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.InlineArrays;

[InlineArray(83)]
public partial struct InlineArray83_SByte : IEquatable<InlineArray83_SByte>, IEqualityOperators<InlineArray83_SByte, InlineArray83_SByte, bool>, IEnumerable, IInlineArray<InlineArray83_SByte, sbyte>, IInlineArray<InlineArray83_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 83;

	public static bool operator ==(InlineArray83_SByte x, InlineArray83_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray83_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray83_SByte x, InlineArray83_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray83_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray83_SByte)
		{
			return Equals((InlineArray83_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray83_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
