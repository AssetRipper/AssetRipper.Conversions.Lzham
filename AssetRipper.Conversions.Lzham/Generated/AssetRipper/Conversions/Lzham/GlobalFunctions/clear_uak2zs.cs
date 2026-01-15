using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?clear@lzcompressor@lzham@@QEAAXXZ")]
[DemangledName("public: void __cdecl lzham::lzcompressor::clear(void)")]
[CleanName("clear")]
internal static partial class clear_uak2zs
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			clear_sksy5s.Invoke(&((lzham_lzcompressor*)@this)->field_6);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			((lzham_lzcompressor*)@this)->field_3 = -1L;
			((lzham_lzcompressor*)@this)->field_4 = 1;
			clear_tzajca.Invoke(&((lzham_lzcompressor*)@this)->field_8);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			clear_tzajca.Invoke(&((lzham_lzcompressor*)@this)->field_9);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			((lzham_lzcompressor*)@this)->field_10 = 0;
			((lzham_lzcompressor*)@this)->field_13 = 0;
			((lzham_lzcompressor*)@this)->field_14 = 0;
			((lzham_lzcompressor*)@this)->field_11 = 0;
			((lzham_lzcompressor*)@this)->field_12 = 0;
			clear_y36py8.Invoke(&((lzham_lzcompressor*)@this)->field_16);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			((lzham_lzcompressor*)@this)->field_17 = 0;
			((lzham_lzcompressor*)@this)->field_19 = 0;
			for (int i = 0; (uint)i < 8u; i++)
			{
				void* ptr = (byte*)(&((lzham_lzcompressor*)@this)->field_18) + (nint)(uint)i * (nint)sizeof(lzham_lzcompressor_parse_thread_state);
				clear_y36py8.Invoke(&((lzham_lzcompressor_raw_parse_thread_state*)ptr)->m_initial_state);
				if (ExceptionInfo.Current != null)
				{
					return;
				}
				for (int j = 0; (uint)j <= 3072u; j++)
				{
					clear_xf8fic.Invoke((byte*)(&((lzham_lzcompressor_raw_parse_thread_state*)ptr)->m_nodes) + (nint)(uint)j * (nint)sizeof(lzham_lzcompressor_node));
				}
				((lzham_lzcompressor_raw_parse_thread_state*)ptr)->m_start_ofs = 0;
				((lzham_lzcompressor_raw_parse_thread_state*)ptr)->m_bytes_to_match = 0;
				clear_hawvcm.Invoke(&((lzham_lzcompressor_raw_parse_thread_state*)ptr)->m_best_decisions);
				if (ExceptionInfo.Current != null)
				{
					return;
				}
				((lzham_lzcompressor_raw_parse_thread_state*)ptr)->m_issue_reset_state_partial = 0;
				((lzham_lzcompressor_raw_parse_thread_state*)ptr)->m_emit_decisions_backwards = 0;
				((lzham_lzcompressor_raw_parse_thread_state*)ptr)->m_failed = 0;
			}
			((lzham_lzcompressor*)@this)->field_22 = 0;
			((lzham_lzcompressor*)@this)->field_23 = 0;
		}
	}
}
