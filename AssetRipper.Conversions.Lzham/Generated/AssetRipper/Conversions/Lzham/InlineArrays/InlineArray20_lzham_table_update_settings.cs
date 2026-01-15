using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.InlineArrays;

[InlineArray(20)]
public partial struct InlineArray20_lzham_table_update_settings : IEquatable<InlineArray20_lzham_table_update_settings>, IEqualityOperators<InlineArray20_lzham_table_update_settings, InlineArray20_lzham_table_update_settings, bool>, IEnumerable, IInlineArray<InlineArray20_lzham_table_update_settings, lzham_table_update_settings>
{
	private lzham_table_update_settings __element0;

	public static int Length => 20;

	public static bool operator ==(InlineArray20_lzham_table_update_settings x, InlineArray20_lzham_table_update_settings y)
	{
		return InlineArrayHelper.Equals<InlineArray20_lzham_table_update_settings, lzham_table_update_settings>(x, y);
	}

	public static bool operator !=(InlineArray20_lzham_table_update_settings x, InlineArray20_lzham_table_update_settings y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray20_lzham_table_update_settings other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray20_lzham_table_update_settings)
		{
			return Equals((InlineArray20_lzham_table_update_settings)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray20_lzham_table_update_settings, lzham_table_update_settings>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<lzham_table_update_settings>)this).GetEnumerator();
	}
}
