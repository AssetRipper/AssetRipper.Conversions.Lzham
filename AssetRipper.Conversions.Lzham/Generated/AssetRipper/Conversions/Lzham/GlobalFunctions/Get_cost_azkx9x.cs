using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?get_cost@adaptive_arith_data_model@lzham@@QEBA_KI@Z")]
[DemangledName("public: unsigned __int64 __cdecl lzham::adaptive_arith_data_model::get_cost(unsigned int) const")]
[CleanName("Get_cost")]
internal static partial class Get_cost_azkx9x
{
	[return: NativeType("unsigned __int64")]
	public unsafe static long Invoke(void* @this, [NativeType("unsigned int")] int sym)
	{
		int num = 1;
		unchecked
		{
			int num2 = ((lzham_adaptive_arith_data_model*)@this)->m_total_syms;
			long num3 = 0L;
			do
			{
				num2 >>>= 1;
				int num4 = InstructionHelper.Select((sym & num2) != 0, 1, 0);
				num3 += Get_cost_2mqzjn.Invoke(vector_class_lzham_adaptive_bit_model_Operator_jj2txr.Invoke(&((lzham_adaptive_arith_data_model*)@this)->m_probs, num), num4);
				num = (num << 1) + num4;
			}
			while ((uint)num2 > 1u);
			return num3;
		}
	}
}
