using System.Runtime.InteropServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.Structures;

[StructLayout(LayoutKind.Explicit, Size = 2)]
[MangledName("class.lzham::adaptive_bit_model")]
[DemangledName("lzham::adaptive_bit_model")]
public partial struct lzham_adaptive_bit_model
{
	[FieldOffset(0)]
	public short m_bit_0_prob;
}
