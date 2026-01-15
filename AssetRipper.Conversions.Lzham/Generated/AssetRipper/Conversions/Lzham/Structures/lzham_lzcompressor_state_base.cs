using System.Runtime.InteropServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.Structures;

[StructLayout(LayoutKind.Explicit, Size = 24)]
[MangledName("struct.lzham::lzcompressor::state_base")]
[DemangledName("lzham::lzcompressor::state_base")]
public partial struct lzham_lzcompressor_state_base
{
	[FieldOffset(0)]
	public int m_cur_ofs;

	[FieldOffset(4)]
	public int m_cur_state;

	[FieldOffset(8)]
	public InlineArray4_Int32 m_match_hist;
}
