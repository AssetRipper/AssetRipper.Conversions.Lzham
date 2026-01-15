using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.InlineArrays;

[InlineArray(53)]
public partial struct InlineArray53_SByte : IEquatable<InlineArray53_SByte>, IEqualityOperators<InlineArray53_SByte, InlineArray53_SByte, bool>, IEnumerable, IInlineArray<InlineArray53_SByte, sbyte>, IInlineArray<InlineArray53_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 53;

	public static bool operator ==(InlineArray53_SByte x, InlineArray53_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray53_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray53_SByte x, InlineArray53_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray53_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray53_SByte)
		{
			return Equals((InlineArray53_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray53_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
