using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?reset_update_rate@state@lzcompressor@lzham@@QEAAXXZ")]
[DemangledName("public: void __cdecl lzham::lzcompressor::state::reset_update_rate(void)")]
[CleanName("reset_update_rate")]
internal static partial class reset_update_rate_ycr949
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			reset_update_rate_r8jzfi.Invoke(&((lzham_lzcompressor_state*)@this)->field_8);
			reset_update_rate_r8jzfi.Invoke(&((lzham_lzcompressor_state*)@this)->field_9);
			reset_update_rate_r8jzfi.Invoke(&((lzham_lzcompressor_state*)@this)->field_10);
			for (int i = 0; (ulong)(uint)i < 2uL; i++)
			{
				reset_update_rate_r8jzfi.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_11) + (nint)(uint)i * (nint)sizeof(lzham_quasi_adaptive_huffman_data_model));
			}
			for (int j = 0; (ulong)(uint)j < 2uL; j++)
			{
				reset_update_rate_r8jzfi.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_12) + (nint)(uint)j * (nint)sizeof(lzham_quasi_adaptive_huffman_data_model));
			}
			reset_update_rate_r8jzfi.Invoke(&((lzham_lzcompressor_state*)@this)->field_13);
		}
	}
}
