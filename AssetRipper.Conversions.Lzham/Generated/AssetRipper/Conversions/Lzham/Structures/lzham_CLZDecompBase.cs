using System.Runtime.InteropServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.Structures;

[StructLayout(LayoutKind.Explicit, Size = 12)]
[MangledName("struct.lzham::CLZDecompBase")]
[DemangledName("lzham::CLZDecompBase")]
public partial struct lzham_CLZDecompBase
{
	[FieldOffset(0)]
	public int m_cur_ofs;

	[FieldOffset(4)]
	public int m_cur_state;

	[FieldOffset(8)]
	public int m_match_hist;
}
