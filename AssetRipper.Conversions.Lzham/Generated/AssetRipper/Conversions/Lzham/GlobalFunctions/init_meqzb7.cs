using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?init@state@lzcompressor@lzham@@QEAA_NAEAUCLZBase@3@II@Z")]
[DemangledName("public: bool __cdecl lzham::lzcompressor::state::init(struct lzham::CLZBase &, unsigned int, unsigned int)")]
[CleanName("init")]
internal static partial class init_meqzb7
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("struct lzham::CLZBase &")] void* lzbase, [NativeType("unsigned int")] int table_max_update_interval, [NativeType("unsigned int")] int table_update_interval_slow_rate)
	{
		unchecked
		{
			((lzham_lzcompressor_state_base*)@this)->m_cur_ofs = 0;
			((lzham_lzcompressor_state_base*)@this)->m_cur_state = 0;
			bool flag = init2.Invoke(&((lzham_lzcompressor_state*)@this)->field_11, encoding: true, 257, table_max_update_interval, table_update_interval_slow_rate, null);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag)
			{
				return false;
			}
			bool flag2 = assign_7mvy2m.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_11) + sizeof(lzham_quasi_adaptive_huffman_data_model), &((lzham_lzcompressor_state*)@this)->field_11);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag2)
			{
				return false;
			}
			bool flag3 = init2.Invoke(&((lzham_lzcompressor_state*)@this)->field_12, encoding: true, 250, table_max_update_interval, table_update_interval_slow_rate, null);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag3)
			{
				return false;
			}
			bool flag4 = assign_7mvy2m.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_12) + sizeof(lzham_quasi_adaptive_huffman_data_model), &((lzham_lzcompressor_state*)@this)->field_12);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag4)
			{
				return false;
			}
			bool flag5 = init2.Invoke(&((lzham_lzcompressor_state*)@this)->field_10, encoding: true, 2 + (((lzham_CLZDecompBase*)lzbase)->m_match_hist - 1) * 8, table_max_update_interval, table_update_interval_slow_rate, null);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag5)
			{
				return false;
			}
			bool flag6 = init2.Invoke(&((lzham_lzcompressor_state*)@this)->field_13, encoding: true, 16, table_max_update_interval, table_update_interval_slow_rate, null);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag6)
			{
				return false;
			}
			bool flag7 = init2.Invoke(&((lzham_lzcompressor_state*)@this)->field_8, encoding: true, 256, table_max_update_interval, table_update_interval_slow_rate, null);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag7)
			{
				return false;
			}
			bool flag8 = init2.Invoke(&((lzham_lzcompressor_state*)@this)->field_9, encoding: true, 256, table_max_update_interval, table_update_interval_slow_rate, null);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag8)
			{
				return false;
			}
			*(int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist) = 1;
			((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[1] = 1;
			((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[2] = 1;
			((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[3] = 1;
			return true;
		}
	}
}
