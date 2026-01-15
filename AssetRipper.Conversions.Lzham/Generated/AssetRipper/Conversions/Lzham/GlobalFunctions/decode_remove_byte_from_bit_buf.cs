using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?decode_remove_byte_from_bit_buf@symbol_codec@lzham@@QEAAHXZ")]
[DemangledName("public: int __cdecl lzham::symbol_codec::decode_remove_byte_from_bit_buf(void)")]
internal static partial class decode_remove_byte_from_bit_buf
{
	[return: NativeType("int")]
	public unsafe static int Invoke(void* @this)
	{
		int result;
		unchecked
		{
			if (((lzham_symbol_codec*)@this)->m_bit_count < 8)
			{
				return -1;
			}
			result = (int)(((lzham_symbol_codec*)@this)->m_bit_buf >>> 56);
			((lzham_symbol_codec*)@this)->m_bit_buf <<= 8;
		}
		unchecked((lzham_symbol_codec*)@this)->m_bit_count -= 8;
		return result;
	}
}
