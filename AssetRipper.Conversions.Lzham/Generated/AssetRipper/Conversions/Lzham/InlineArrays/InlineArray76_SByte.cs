using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.InlineArrays;

[InlineArray(76)]
public partial struct InlineArray76_SByte : IEquatable<InlineArray76_SByte>, IEqualityOperators<InlineArray76_SByte, InlineArray76_SByte, bool>, IEnumerable, IInlineArray<InlineArray76_SByte, sbyte>, IInlineArray<InlineArray76_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 76;

	public static bool operator ==(InlineArray76_SByte x, InlineArray76_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray76_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray76_SByte x, InlineArray76_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray76_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray76_SByte)
		{
			return Equals((InlineArray76_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray76_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
