using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.InlineArrays;

[InlineArray(78)]
public partial struct InlineArray78_SByte : IEquatable<InlineArray78_SByte>, IEqualityOperators<InlineArray78_SByte, InlineArray78_SByte, bool>, IEnumerable, IInlineArray<InlineArray78_SByte, sbyte>, IInlineArray<InlineArray78_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 78;

	public static bool operator ==(InlineArray78_SByte x, InlineArray78_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray78_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray78_SByte x, InlineArray78_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray78_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray78_SByte)
		{
			return Equals((InlineArray78_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray78_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
