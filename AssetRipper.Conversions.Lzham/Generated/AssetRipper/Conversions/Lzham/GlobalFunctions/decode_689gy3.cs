using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?decode@symbol_codec@lzham@@QEAAIAEAVadaptive_arith_data_model@2@@Z")]
[DemangledName("public: unsigned int __cdecl lzham::symbol_codec::decode(class lzham::adaptive_arith_data_model &)")]
[CleanName("decode")]
internal static partial class decode_689gy3
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke(void* @this, [NativeType("class lzham::adaptive_arith_data_model &")] void* model)
	{
		int num = 1;
		unchecked
		{
			do
			{
				int num2 = decode_vnvphn.Invoke(@this, vector_class_lzham_adaptive_bit_model_Operator_he3z72.Invoke(&((lzham_adaptive_arith_data_model*)model)->m_probs, num), update_model: true);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				num = (num << 1) + num2;
			}
			while ((uint)num < (uint)((lzham_adaptive_arith_data_model*)model)->m_total_syms);
			return num - ((lzham_adaptive_arith_data_model*)model)->m_total_syms;
		}
	}
}
