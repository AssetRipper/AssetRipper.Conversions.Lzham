using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?init@adaptive_arith_data_model@lzham@@QEAA_N_NI@Z")]
[DemangledName("public: bool __cdecl lzham::adaptive_arith_data_model::init(bool, unsigned int)")]
[CleanName("init")]
internal static partial class init_fxxkt6
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("bool")] bool encoding, [NativeType("unsigned int")] int total_syms)
	{
		int num = total_syms;
		if (num == 0)
		{
			clear_3kmniu.Invoke(@this);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			return true;
		}
		unchecked
		{
			if ((uint)num < 2u || !is_power_of_2_igmcwk.Invoke(num))
			{
				num = next_pow2_sz9rvk.Invoke(num);
			}
			((lzham_adaptive_arith_data_model*)@this)->m_total_syms = num;
			bool flag = try_resize_dw23aw.Invoke(&((lzham_adaptive_arith_data_model*)@this)->m_probs, ((lzham_adaptive_arith_data_model*)@this)->m_total_syms, grow_hint: false);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag)
			{
				return false;
			}
			return true;
		}
	}
}
