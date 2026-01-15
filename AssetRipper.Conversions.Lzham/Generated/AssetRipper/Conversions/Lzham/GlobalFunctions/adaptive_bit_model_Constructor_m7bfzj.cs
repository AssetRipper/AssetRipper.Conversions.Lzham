using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??0adaptive_bit_model@lzham@@QEAA@AEBV01@@Z")]
[DemangledName("public: __cdecl lzham::adaptive_bit_model::adaptive_bit_model(class lzham::adaptive_bit_model const &)")]
[CleanName("adaptive_bit_model_Constructor")]
internal static partial class adaptive_bit_model_Constructor_m7bfzj
{
	public unsafe static void* Invoke(void* @this, [NativeType("class lzham::adaptive_bit_model const &")] void* other)
	{
		unchecked
		{
			short* bit_0_prob = &((lzham_adaptive_bit_model*)@this)->m_bit_0_prob;
			*bit_0_prob = ((lzham_adaptive_bit_model*)other)->m_bit_0_prob;
			return @this;
		}
	}
}
