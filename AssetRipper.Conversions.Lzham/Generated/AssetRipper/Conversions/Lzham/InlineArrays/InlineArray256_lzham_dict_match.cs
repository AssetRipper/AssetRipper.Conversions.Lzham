using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.InlineArrays;

[InlineArray(256)]
public partial struct InlineArray256_lzham_dict_match : IEquatable<InlineArray256_lzham_dict_match>, IEqualityOperators<InlineArray256_lzham_dict_match, InlineArray256_lzham_dict_match, bool>, IEnumerable, IInlineArray<InlineArray256_lzham_dict_match, lzham_dict_match>
{
	private lzham_dict_match __element0;

	public static int Length => 256;

	public static bool operator ==(InlineArray256_lzham_dict_match x, InlineArray256_lzham_dict_match y)
	{
		return InlineArrayHelper.Equals<InlineArray256_lzham_dict_match, lzham_dict_match>(x, y);
	}

	public static bool operator !=(InlineArray256_lzham_dict_match x, InlineArray256_lzham_dict_match y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray256_lzham_dict_match other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray256_lzham_dict_match)
		{
			return Equals((InlineArray256_lzham_dict_match)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray256_lzham_dict_match, lzham_dict_match>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<lzham_dict_match>)this).GetEnumerator();
	}
}
