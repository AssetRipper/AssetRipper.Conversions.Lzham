using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??4adaptive_bit_model@lzham@@QEAAAEAV01@AEBV01@@Z")]
[DemangledName("public: class lzham::adaptive_bit_model & __cdecl lzham::adaptive_bit_model::operator=(class lzham::adaptive_bit_model const &)")]
internal static partial class adaptive_bit_model_Assignment
{
	[return: NativeType("class lzham::adaptive_bit_model &")]
	public unsafe static void* Invoke(void* @this, [NativeType("class lzham::adaptive_bit_model const &")] void* rhs)
	{
		unchecked
		{
			((lzham_adaptive_bit_model*)@this)->m_bit_0_prob = ((lzham_adaptive_bit_model*)rhs)->m_bit_0_prob;
			return @this;
		}
	}
}
