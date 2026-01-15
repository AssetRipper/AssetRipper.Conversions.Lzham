using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?reset@adaptive_arith_data_model@lzham@@QEAAXXZ")]
[DemangledName("public: void __cdecl lzham::adaptive_arith_data_model::reset(void)")]
[CleanName("reset")]
internal static partial class reset_7s26kf
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			for (int i = 0; (uint)i < (uint)size_eeqcx3.Invoke(&((lzham_adaptive_arith_data_model*)@this)->m_probs); i++)
			{
				clear_ezdf43.Invoke(vector_class_lzham_adaptive_bit_model_Operator_he3z72.Invoke(&((lzham_adaptive_arith_data_model*)@this)->m_probs, i));
			}
		}
	}
}
