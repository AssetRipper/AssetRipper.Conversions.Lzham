using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?clear@state@lzcompressor@lzham@@QEAAXXZ")]
[DemangledName("public: void __cdecl lzham::lzcompressor::state::clear(void)")]
[CleanName("clear")]
internal static partial class clear_y36py8
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			((lzham_lzcompressor_state_base*)@this)->m_cur_ofs = 0;
			((lzham_lzcompressor_state_base*)@this)->m_cur_state = 0;
			((lzham_lzcompressor_state*)@this)->field_1 = 0;
			for (int i = 0; (uint)i < 2u; i++)
			{
				clear_bzp3jp.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_11) + (nint)(uint)i * (nint)sizeof(lzham_quasi_adaptive_huffman_data_model));
				if (ExceptionInfo.Current != null)
				{
					return;
				}
				clear_bzp3jp.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_12) + (nint)(uint)i * (nint)sizeof(lzham_quasi_adaptive_huffman_data_model));
				if (ExceptionInfo.Current != null)
				{
					return;
				}
			}
			clear_bzp3jp.Invoke(&((lzham_lzcompressor_state*)@this)->field_10);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			clear_bzp3jp.Invoke(&((lzham_lzcompressor_state*)@this)->field_13);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			clear_bzp3jp.Invoke(&((lzham_lzcompressor_state*)@this)->field_8);
			if (ExceptionInfo.Current == null)
			{
				clear_bzp3jp.Invoke(&((lzham_lzcompressor_state*)@this)->field_9);
				if (ExceptionInfo.Current == null)
				{
					*(int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist) = 1;
					((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[1] = 1;
					((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[2] = 1;
					((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[3] = 1;
				}
			}
		}
	}
}
