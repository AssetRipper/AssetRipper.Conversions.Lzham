using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??4adaptive_arith_data_model@lzham@@QEAAAEAV01@AEBV01@@Z")]
[DemangledName("public: class lzham::adaptive_arith_data_model & __cdecl lzham::adaptive_arith_data_model::operator=(class lzham::adaptive_arith_data_model const &)")]
internal static partial class adaptive_arith_data_model_Assignment
{
	[return: NativeType("class lzham::adaptive_arith_data_model &")]
	public unsafe static void* Invoke(void* @this, [NativeType("class lzham::adaptive_arith_data_model const &")] void* rhs)
	{
		unchecked
		{
			((lzham_adaptive_arith_data_model*)@this)->m_total_syms = ((lzham_adaptive_arith_data_model*)rhs)->m_total_syms;
			vector_class_lzham_adaptive_bit_model_Assignment.Invoke(other: &((lzham_adaptive_arith_data_model*)rhs)->m_probs, @this: &((lzham_adaptive_arith_data_model*)@this)->m_probs);
			if (ExceptionInfo.Current != null)
			{
				return null;
			}
			return @this;
		}
	}
}
