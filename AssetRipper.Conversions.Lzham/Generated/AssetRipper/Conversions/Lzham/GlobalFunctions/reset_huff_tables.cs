using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?reset_huff_tables@lzham_decompressor@lzham@@QEAAXXZ")]
[DemangledName("public: void __cdecl lzham::lzham_decompressor::reset_huff_tables(void)")]
internal static partial class reset_huff_tables
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			reset_kva6fy.Invoke(&((lzham_lzham_decompressor*)@this)->m_lit_table);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			reset_kva6fy.Invoke(&((lzham_lzham_decompressor*)@this)->m_delta_lit_table);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			reset_kva6fy.Invoke(&((lzham_lzham_decompressor*)@this)->m_main_table);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			for (int i = 0; (ulong)(uint)i < 2uL; i++)
			{
				reset_kva6fy.Invoke((byte*)(&((lzham_lzham_decompressor*)@this)->m_rep_len_table) + (nint)(uint)i * (nint)sizeof(lzham_quasi_adaptive_huffman_data_model));
				if (ExceptionInfo.Current != null)
				{
					return;
				}
			}
			for (int j = 0; (ulong)(uint)j < 2uL; j++)
			{
				reset_kva6fy.Invoke((byte*)(&((lzham_lzham_decompressor*)@this)->m_large_len_table) + (nint)(uint)j * (nint)sizeof(lzham_quasi_adaptive_huffman_data_model));
				if (ExceptionInfo.Current != null)
				{
					return;
				}
			}
			reset_kva6fy.Invoke(&((lzham_lzham_decompressor*)@this)->m_dist_lsb_table);
		}
	}
}
