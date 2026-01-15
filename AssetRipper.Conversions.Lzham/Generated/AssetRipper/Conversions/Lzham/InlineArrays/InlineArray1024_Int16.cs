using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.InlineArrays;

[InlineArray(1024)]
public partial struct InlineArray1024_Int16 : IEquatable<InlineArray1024_Int16>, IEqualityOperators<InlineArray1024_Int16, InlineArray1024_Int16, bool>, IEnumerable, IInlineArray<InlineArray1024_Int16, short>, IInlineArray<InlineArray1024_Int16, ushort>, IInlineArray<InlineArray1024_Int16, char>
{
	private short __element0;

	public static int Length => 1024;

	public static bool operator ==(InlineArray1024_Int16 x, InlineArray1024_Int16 y)
	{
		return InlineArrayHelper.Equals<InlineArray1024_Int16, short>(x, y);
	}

	public static bool operator !=(InlineArray1024_Int16 x, InlineArray1024_Int16 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray1024_Int16 other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray1024_Int16)
		{
			return Equals((InlineArray1024_Int16)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray1024_Int16, short>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<short>)this).GetEnumerator();
	}
}
