using System.Runtime.InteropServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.Structures;

[StructLayout(LayoutKind.Explicit, Size = 40)]
[MangledName("class.lzham::lzcompressor::tracked_stat")]
[DemangledName("lzham::lzcompressor::tracked_stat")]
public partial struct lzham_lzcompressor_tracked_stat
{
	[FieldOffset(0)]
	public long m_num;

	[FieldOffset(8)]
	public double m_total;

	[FieldOffset(16)]
	public double m_total2;

	[FieldOffset(24)]
	public double m_min_val;

	[FieldOffset(32)]
	public double m_max_val;
}
