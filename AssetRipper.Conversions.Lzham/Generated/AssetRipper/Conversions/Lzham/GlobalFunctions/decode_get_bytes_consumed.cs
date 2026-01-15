using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?decode_get_bytes_consumed@symbol_codec@lzham@@QEBA_KXZ")]
[DemangledName("public: unsigned __int64 __cdecl lzham::symbol_codec::decode_get_bytes_consumed(void) const")]
internal static partial class decode_get_bytes_consumed
{
	[return: NativeType("unsigned __int64")]
	public unsafe static long Invoke(void* @this)
	{
		return unchecked((long)((lzham_symbol_codec*)@this)->m_pDecode_buf_next - (long)((lzham_symbol_codec*)@this)->m_pDecode_buf);
	}
}
