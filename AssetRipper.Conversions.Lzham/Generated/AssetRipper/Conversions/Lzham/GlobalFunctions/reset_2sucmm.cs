using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?reset@state@lzcompressor@lzham@@QEAAXXZ")]
[DemangledName("public: void __cdecl lzham::lzcompressor::state::reset(void)")]
[CleanName("reset")]
internal static partial class reset_2sucmm
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			((lzham_lzcompressor_state_base*)@this)->m_cur_ofs = 0;
			((lzham_lzcompressor_state_base*)@this)->m_cur_state = 0;
			((lzham_lzcompressor_state*)@this)->field_1 = 0;
			for (int i = 0; (ulong)(uint)i < 12uL; i++)
			{
				clear_ezdf43.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_2) + (nint)(uint)i * (nint)sizeof(lzham_adaptive_bit_model));
			}
			for (int j = 0; (ulong)(uint)j < 12uL; j++)
			{
				clear_ezdf43.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_3) + (nint)(uint)j * (nint)sizeof(lzham_adaptive_bit_model));
			}
			for (int k = 0; (ulong)(uint)k < 12uL; k++)
			{
				clear_ezdf43.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_4) + (nint)(uint)k * (nint)sizeof(lzham_adaptive_bit_model));
			}
			for (int l = 0; (ulong)(uint)l < 12uL; l++)
			{
				clear_ezdf43.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_5) + (nint)(uint)l * (nint)sizeof(lzham_adaptive_bit_model));
			}
			for (int m = 0; (ulong)(uint)m < 12uL; m++)
			{
				clear_ezdf43.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_6) + (nint)(uint)m * (nint)sizeof(lzham_adaptive_bit_model));
			}
			for (int n = 0; (ulong)(uint)n < 12uL; n++)
			{
				clear_ezdf43.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_7) + (nint)(uint)n * (nint)sizeof(lzham_adaptive_bit_model));
			}
			for (int num = 0; (uint)num < 2u; num++)
			{
				reset_kva6fy.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_11) + (nint)(uint)num * (nint)sizeof(lzham_quasi_adaptive_huffman_data_model));
				if (ExceptionInfo.Current != null)
				{
					return;
				}
				reset_kva6fy.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_12) + (nint)(uint)num * (nint)sizeof(lzham_quasi_adaptive_huffman_data_model));
				if (ExceptionInfo.Current != null)
				{
					return;
				}
			}
			reset_kva6fy.Invoke(&((lzham_lzcompressor_state*)@this)->field_10);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			reset_kva6fy.Invoke(&((lzham_lzcompressor_state*)@this)->field_13);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			reset_kva6fy.Invoke(&((lzham_lzcompressor_state*)@this)->field_8);
			if (ExceptionInfo.Current == null)
			{
				reset_kva6fy.Invoke(&((lzham_lzcompressor_state*)@this)->field_9);
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
