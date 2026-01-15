using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??0adaptive_arith_data_model@lzham@@QEAA@_NI@Z")]
[DemangledName("public: __cdecl lzham::adaptive_arith_data_model::adaptive_arith_data_model(bool, unsigned int)")]
[CleanName("adaptive_arith_data_model_Constructor")]
internal static partial class adaptive_arith_data_model_Constructor_qhe94u
{
	public unsafe static void* Invoke(void* @this, [NativeType("bool")] bool encoding, [NativeType("unsigned int")] int total_syms)
	{
		sbyte b = (encoding ? ((sbyte)1) : ((sbyte)0));
		lzham_vector* probs = &unchecked((lzham_adaptive_arith_data_model*)@this)->m_probs;
		vector_class_lzham_adaptive_bit_model_Constructor.Invoke(probs);
		init_fxxkt6.Invoke(@this, (b & 1) == 1, total_syms);
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
