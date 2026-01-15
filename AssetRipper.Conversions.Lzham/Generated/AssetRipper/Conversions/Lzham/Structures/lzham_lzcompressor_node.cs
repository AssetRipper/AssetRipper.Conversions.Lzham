using System.Runtime.InteropServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.Structures;

[StructLayout(LayoutKind.Explicit, Size = 232)]
[MangledName("struct.lzham::lzcompressor::node")]
[DemangledName("lzham::lzcompressor::node")]
public partial struct lzham_lzcompressor_node
{
	[FieldOffset(0)]
	public int m_num_node_states;

	[FieldOffset(8)]
	public InlineArray4_lzham_lzcompressor_node_state m_node_states;
}
