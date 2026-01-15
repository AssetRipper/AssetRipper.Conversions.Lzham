using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?reset_huffman_table_update_rates@lzham_decompressor@lzham@@QEAAXXZ")]
[DemangledName("public: void __cdecl lzham::lzham_decompressor::reset_huffman_table_update_rates(void)")]
internal static partial class reset_huffman_table_update_rates
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			reset_update_rate_r8jzfi.Invoke(&((lzham_lzham_decompressor*)@this)->m_lit_table);
			reset_update_rate_r8jzfi.Invoke(&((lzham_lzham_decompressor*)@this)->m_delta_lit_table);
			reset_update_rate_r8jzfi.Invoke(&((lzham_lzham_decompressor*)@this)->m_main_table);
			for (int i = 0; (ulong)(uint)i < 2uL; i++)
			{
				reset_update_rate_r8jzfi.Invoke((byte*)(&((lzham_lzham_decompressor*)@this)->m_rep_len_table) + (nint)(uint)i * (nint)sizeof(lzham_quasi_adaptive_huffman_data_model));
			}
			for (int j = 0; (ulong)(uint)j < 2uL; j++)
			{
				reset_update_rate_r8jzfi.Invoke((byte*)(&((lzham_lzham_decompressor*)@this)->m_large_len_table) + (nint)(uint)j * (nint)sizeof(lzham_quasi_adaptive_huffman_data_model));
			}
			reset_update_rate_r8jzfi.Invoke(&((lzham_lzham_decompressor*)@this)->m_dist_lsb_table);
		}
	}
}
