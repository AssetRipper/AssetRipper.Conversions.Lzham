using System.Runtime.InteropServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.Structures;

[StructLayout(LayoutKind.Explicit, Size = 16)]
[MangledName("struct.lzham::lzcompressor::block_history")]
[DemangledName("lzham::lzcompressor::block_history")]
public partial struct lzham_lzcompressor_block_history
{
	[FieldOffset(0)]
	public int m_comp_size;

	[FieldOffset(4)]
	public int m_src_size;

	[FieldOffset(8)]
	public int m_ratio;

	[FieldOffset(12)]
	public sbyte m_raw_block;

	[FieldOffset(13)]
	public sbyte m_reset_update_rate;
}
