using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?reset_arith_tables@lzham_decompressor@lzham@@QEAAXXZ")]
[DemangledName("public: void __cdecl lzham::lzham_decompressor::reset_arith_tables(void)")]
internal static partial class reset_arith_tables
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			for (int i = 0; (ulong)(uint)i < 12uL; i++)
			{
				clear_ezdf43.Invoke((byte*)(&((lzham_lzham_decompressor*)@this)->m_is_match_model) + (nint)(uint)i * (nint)sizeof(lzham_adaptive_bit_model));
			}
			for (int j = 0; (uint)j < 12u; j++)
			{
				clear_ezdf43.Invoke((byte*)(&((lzham_lzham_decompressor*)@this)->m_is_rep_model) + (nint)(uint)j * (nint)sizeof(lzham_adaptive_bit_model));
				clear_ezdf43.Invoke((byte*)(&((lzham_lzham_decompressor*)@this)->m_is_rep0_model) + (nint)(uint)j * (nint)sizeof(lzham_adaptive_bit_model));
				clear_ezdf43.Invoke((byte*)(&((lzham_lzham_decompressor*)@this)->m_is_rep0_single_byte_model) + (nint)(uint)j * (nint)sizeof(lzham_adaptive_bit_model));
				clear_ezdf43.Invoke((byte*)(&((lzham_lzham_decompressor*)@this)->m_is_rep1_model) + (nint)(uint)j * (nint)sizeof(lzham_adaptive_bit_model));
				clear_ezdf43.Invoke((byte*)(&((lzham_lzham_decompressor*)@this)->m_is_rep2_model) + (nint)(uint)j * (nint)sizeof(lzham_adaptive_bit_model));
			}
		}
	}
}
