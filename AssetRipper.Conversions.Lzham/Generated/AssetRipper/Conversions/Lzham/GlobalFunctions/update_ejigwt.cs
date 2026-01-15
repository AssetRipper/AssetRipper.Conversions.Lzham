using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?update@adaptive_arith_data_model@lzham@@QEAA_NI@Z")]
[DemangledName("public: bool __cdecl lzham::adaptive_arith_data_model::update(unsigned int)")]
[CleanName("update")]
internal static partial class update_ejigwt
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("unsigned int")] int sym)
	{
		int num = 1;
		unchecked
		{
			int num2 = ((lzham_adaptive_arith_data_model*)@this)->m_total_syms;
			do
			{
				num2 >>>= 1;
				int num3 = InstructionHelper.Select((sym & num2) != 0, 1, 0);
				update_yyeigq.Invoke(vector_class_lzham_adaptive_bit_model_Operator_he3z72.Invoke(&((lzham_adaptive_arith_data_model*)@this)->m_probs, num), num3);
				num = (num << 1) + num3;
			}
			while ((uint)num2 > 1u);
			return true;
		}
	}
}
