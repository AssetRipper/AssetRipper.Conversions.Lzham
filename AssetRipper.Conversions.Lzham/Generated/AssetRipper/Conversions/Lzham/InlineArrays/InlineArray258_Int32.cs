using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.InlineArrays;

[InlineArray(258)]
public partial struct InlineArray258_Int32 : IEquatable<InlineArray258_Int32>, IEqualityOperators<InlineArray258_Int32, InlineArray258_Int32, bool>, IEnumerable, IInlineArray<InlineArray258_Int32, int>, IInlineArray<InlineArray258_Int32, uint>
{
	private int __element0;

	public static int Length => 258;

	public static bool operator ==(InlineArray258_Int32 x, InlineArray258_Int32 y)
	{
		return InlineArrayHelper.Equals<InlineArray258_Int32, int>(x, y);
	}

	public static bool operator !=(InlineArray258_Int32 x, InlineArray258_Int32 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray258_Int32 other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray258_Int32)
		{
			return Equals((InlineArray258_Int32)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray258_Int32, int>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<int>)this).GetEnumerator();
	}
}
