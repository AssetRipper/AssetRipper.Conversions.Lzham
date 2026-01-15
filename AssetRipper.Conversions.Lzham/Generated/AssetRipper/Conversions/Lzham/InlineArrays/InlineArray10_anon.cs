using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.InlineArrays;

[InlineArray(10)]
public partial struct InlineArray10_anon : IEquatable<InlineArray10_anon>, IEqualityOperators<InlineArray10_anon, InlineArray10_anon, bool>, IEnumerable, IInlineArray<InlineArray10_anon, anon>
{
	private anon __element0;

	public static int Length => 10;

	public static bool operator ==(InlineArray10_anon x, InlineArray10_anon y)
	{
		return InlineArrayHelper.Equals<InlineArray10_anon, anon>(x, y);
	}

	public static bool operator !=(InlineArray10_anon x, InlineArray10_anon y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray10_anon other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray10_anon)
		{
			return Equals((InlineArray10_anon)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray10_anon, anon>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<anon>)this).GetEnumerator();
	}
}
