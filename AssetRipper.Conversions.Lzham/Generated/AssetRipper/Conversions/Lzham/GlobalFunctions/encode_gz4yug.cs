using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?encode@symbol_codec@lzham@@QEAA_NIAEAVadaptive_arith_data_model@2@@Z")]
[DemangledName("public: bool __cdecl lzham::symbol_codec::encode(unsigned int, class lzham::adaptive_arith_data_model &)")]
[CleanName("encode")]
internal static partial class encode_gz4yug
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("unsigned int")] int sym, [NativeType("class lzham::adaptive_arith_data_model &")] void* model)
	{
		int num = 1;
		unchecked
		{
			int num2 = ((lzham_adaptive_arith_data_model*)model)->m_total_syms;
			do
			{
				num2 >>>= 1;
				int num3 = InstructionHelper.Select((sym & num2) != 0, 1, 0);
				bool flag = encode_ay6s5b.Invoke(@this, num3, vector_class_lzham_adaptive_bit_model_Operator_he3z72.Invoke(&((lzham_adaptive_arith_data_model*)model)->m_probs, num), update_model: true);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (!flag)
				{
					return false;
				}
				num = (num << 1) + num3;
			}
			while ((uint)num2 > 1u);
			return true;
		}
	}
}
