using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?set_probability_0@adaptive_bit_model@lzham@@QEAAXM@Z")]
[DemangledName("public: void __cdecl lzham::adaptive_bit_model::set_probability_0(float)")]
internal static partial class Set_probability_0
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this, [NativeType("float")] float prob0)
	{
		unchecked
		{
			((lzham_adaptive_bit_model*)@this)->m_bit_0_prob = (short)clamp.Invoke((int)(uint)(prob0 * 2048f), 1, 2047);
		}
	}
}
