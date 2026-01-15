using System.Runtime.InteropServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.Structures;

[StructLayout(LayoutKind.Explicit, Size = 8)]
[MangledName("struct.lzham::sym_freq")]
[DemangledName("lzham::sym_freq")]
public partial struct lzham_sym_freq
{
	[FieldOffset(0)]
	public int m_freq;

	[FieldOffset(4)]
	public short m_left;

	[FieldOffset(6)]
	public short m_right;
}
