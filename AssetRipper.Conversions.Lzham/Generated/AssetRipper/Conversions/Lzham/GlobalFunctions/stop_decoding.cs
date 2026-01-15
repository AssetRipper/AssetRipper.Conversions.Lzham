using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?stop_decoding@symbol_codec@lzham@@QEAA_KXZ")]
[DemangledName("public: unsigned __int64 __cdecl lzham::symbol_codec::stop_decoding(void)")]
internal static partial class stop_decoding
{
	[return: NativeType("unsigned __int64")]
	public unsafe static long Invoke(void* @this)
	{
		unchecked
		{
			long result = (long)((lzham_symbol_codec*)@this)->m_pDecode_buf_next - (long)((lzham_symbol_codec*)@this)->m_pDecode_buf;
			((lzham_symbol_codec*)@this)->m_mode = 0;
			return result;
		}
	}
}
