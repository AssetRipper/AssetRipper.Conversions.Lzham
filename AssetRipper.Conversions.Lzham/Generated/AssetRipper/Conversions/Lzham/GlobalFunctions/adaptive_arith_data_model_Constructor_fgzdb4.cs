using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??0adaptive_arith_data_model@lzham@@QEAA@AEBV01@@Z")]
[DemangledName("public: __cdecl lzham::adaptive_arith_data_model::adaptive_arith_data_model(class lzham::adaptive_arith_data_model const &)")]
[CleanName("adaptive_arith_data_model_Constructor")]
internal static partial class adaptive_arith_data_model_Constructor_fgzdb4
{
	public unsafe static void* Invoke(void* @this, [NativeType("class lzham::adaptive_arith_data_model const &")] void* other)
	{
		unchecked
		{
			lzham_vector* probs = &((lzham_adaptive_arith_data_model*)@this)->m_probs;
			vector_class_lzham_adaptive_bit_model_Constructor.Invoke(probs);
			((lzham_adaptive_arith_data_model*)@this)->m_total_syms = ((lzham_adaptive_arith_data_model*)other)->m_total_syms;
			vector_class_lzham_adaptive_bit_model_Assignment.Invoke(other: &((lzham_adaptive_arith_data_model*)other)->m_probs, @this: &((lzham_adaptive_arith_data_model*)@this)->m_probs);
			if (ExceptionInfo.Current == null)
			{
				return @this;
			}
			ExceptionInfo current = ExceptionInfo.Current;
			ExceptionInfo.Current = null;
			vector_class_lzham_adaptive_bit_model_Destructor.Invoke(probs);
			if (ExceptionInfo.Current != null)
			{
				return null;
			}
			ExceptionInfo.Current = current;
			return null;
		}
	}
}
