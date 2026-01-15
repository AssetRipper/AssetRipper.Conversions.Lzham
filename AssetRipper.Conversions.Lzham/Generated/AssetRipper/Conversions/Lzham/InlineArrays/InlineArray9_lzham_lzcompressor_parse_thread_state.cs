using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.InlineArrays;

[InlineArray(9)]
public partial struct InlineArray9_lzham_lzcompressor_parse_thread_state : IEquatable<InlineArray9_lzham_lzcompressor_parse_thread_state>, IEqualityOperators<InlineArray9_lzham_lzcompressor_parse_thread_state, InlineArray9_lzham_lzcompressor_parse_thread_state, bool>, IEnumerable, IInlineArray<InlineArray9_lzham_lzcompressor_parse_thread_state, lzham_lzcompressor_parse_thread_state>
{
	private lzham_lzcompressor_parse_thread_state __element0;

	public static int Length => 9;

	public static bool operator ==(InlineArray9_lzham_lzcompressor_parse_thread_state x, InlineArray9_lzham_lzcompressor_parse_thread_state y)
	{
		return InlineArrayHelper.Equals<InlineArray9_lzham_lzcompressor_parse_thread_state, lzham_lzcompressor_parse_thread_state>(x, y);
	}

	public static bool operator !=(InlineArray9_lzham_lzcompressor_parse_thread_state x, InlineArray9_lzham_lzcompressor_parse_thread_state y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray9_lzham_lzcompressor_parse_thread_state other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray9_lzham_lzcompressor_parse_thread_state)
		{
			return Equals((InlineArray9_lzham_lzcompressor_parse_thread_state)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray9_lzham_lzcompressor_parse_thread_state, lzham_lzcompressor_parse_thread_state>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<lzham_lzcompressor_parse_thread_state>)this).GetEnumerator();
	}
}
