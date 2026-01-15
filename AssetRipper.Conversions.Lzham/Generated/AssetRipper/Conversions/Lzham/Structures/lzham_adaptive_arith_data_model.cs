using System.Runtime.InteropServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.Structures;

[StructLayout(LayoutKind.Explicit, Size = 24)]
[MangledName("class.lzham::adaptive_arith_data_model")]
[DemangledName("lzham::adaptive_arith_data_model")]
public partial struct lzham_adaptive_arith_data_model
{
	[FieldOffset(0)]
	public int m_total_syms;

	[FieldOffset(8)]
	public lzham_vector m_probs;
}
