using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.InlineArrays;

[InlineArray(77)]
public partial struct InlineArray77_SByte : IEquatable<InlineArray77_SByte>, IEqualityOperators<InlineArray77_SByte, InlineArray77_SByte, bool>, IEnumerable, IInlineArray<InlineArray77_SByte, sbyte>, IInlineArray<InlineArray77_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 77;

	public static bool operator ==(InlineArray77_SByte x, InlineArray77_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray77_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray77_SByte x, InlineArray77_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray77_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray77_SByte)
		{
			return Equals((InlineArray77_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray77_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
