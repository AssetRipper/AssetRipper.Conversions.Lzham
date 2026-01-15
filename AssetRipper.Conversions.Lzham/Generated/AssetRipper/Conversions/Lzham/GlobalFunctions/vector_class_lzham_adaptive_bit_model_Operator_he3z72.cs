using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??A?$vector@Vadaptive_bit_model@lzham@@@lzham@@QEAAAEAVadaptive_bit_model@1@I@Z")]
[DemangledName("public: class lzham::adaptive_bit_model & __cdecl lzham::vector<class lzham::adaptive_bit_model>::operator[](unsigned int)")]
[CleanName("vector_class_lzham_adaptive_bit_model_Operator")]
internal static partial class vector_class_lzham_adaptive_bit_model_Operator_he3z72
{
	[return: NativeType("class lzham::adaptive_bit_model &")]
	public unsafe static void* Invoke(void* @this, [NativeType("unsigned int")] int i)
	{
		return unchecked((byte*)((lzham_vector*)@this)->m_p + (nint)(uint)i * (nint)sizeof(lzham_adaptive_bit_model));
	}
}
