using System.Runtime.InteropServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.Structures;

[StructLayout(LayoutKind.Explicit, Size = 56)]
[MangledName("struct.lzham::lzcompressor::node_state")]
[DemangledName("lzham::lzcompressor::node_state")]
public partial struct lzham_lzcompressor_node_state
{
	[FieldOffset(0)]
	public lzham_CLZDecompBase m_lzdec;

	[FieldOffset(12)]
	public lzham_lzcompressor_state_base m_saved_state;

	[FieldOffset(40)]
	public long m_total_cost;

	[FieldOffset(48)]
	public int m_total_complexity;

	[FieldOffset(52)]
	public short m_parent_index;

	[FieldOffset(54)]
	public sbyte m_parent_state_index;
}
