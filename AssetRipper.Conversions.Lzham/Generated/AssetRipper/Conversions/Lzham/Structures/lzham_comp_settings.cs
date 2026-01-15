using System.Runtime.InteropServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.Structures;

[StructLayout(LayoutKind.Explicit, Size = 16)]
[MangledName("struct.lzham::comp_settings")]
[DemangledName("lzham::comp_settings")]
public partial struct lzham_comp_settings
{
	[FieldOffset(0)]
	public int m_fast_bytes;

	[FieldOffset(4)]
	public sbyte m_fast_adaptive_huffman_updating;

	[FieldOffset(8)]
	public int m_match_accel_max_matches_per_probe;

	[FieldOffset(12)]
	public int m_match_accel_max_probes;
}
