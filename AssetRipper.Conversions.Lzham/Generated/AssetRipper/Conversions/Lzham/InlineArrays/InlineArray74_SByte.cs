using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.InlineArrays;

[InlineArray(74)]
public partial struct InlineArray74_SByte : IEquatable<InlineArray74_SByte>, IEqualityOperators<InlineArray74_SByte, InlineArray74_SByte, bool>, IEnumerable, IInlineArray<InlineArray74_SByte, sbyte>, IInlineArray<InlineArray74_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 74;

	public static bool operator ==(InlineArray74_SByte x, InlineArray74_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray74_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray74_SByte x, InlineArray74_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray74_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray74_SByte)
		{
			return Equals((InlineArray74_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray74_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
