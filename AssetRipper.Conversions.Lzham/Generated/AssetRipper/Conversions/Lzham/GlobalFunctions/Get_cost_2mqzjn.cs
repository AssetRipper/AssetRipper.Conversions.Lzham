using AssetRipper.Conversions.Lzham.GlobalVariables;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?get_cost@adaptive_bit_model@lzham@@QEBA_KI@Z")]
[DemangledName("public: unsigned __int64 __cdecl lzham::adaptive_bit_model::get_cost(unsigned int) const")]
[CleanName("Get_cost")]
internal static partial class Get_cost_2mqzjn
{
	[return: NativeType("unsigned __int64")]
	public unsafe static long Invoke(void* @this, [NativeType("unsigned int")] int bit)
	{
		unchecked
		{
			int num = ((bit == 0) ? ((ushort)((lzham_adaptive_bit_model*)@this)->m_bit_0_prob) : (2048 - (ushort)((lzham_adaptive_bit_model*)@this)->m_bit_0_prob));
			return (uint)((int*)g_prob_cost.__pointer)[(uint)num];
		}
	}
}
