using System.Runtime.InteropServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.Structures;

[StructLayout(LayoutKind.Explicit, Size = 6)]
[MangledName("struct.lzham::dict_match")]
[DemangledName("lzham::dict_match")]
public partial struct lzham_dict_match
{
	[FieldOffset(0)]
	public int m_dist;

	[FieldOffset(4)]
	public short m_len;
}
