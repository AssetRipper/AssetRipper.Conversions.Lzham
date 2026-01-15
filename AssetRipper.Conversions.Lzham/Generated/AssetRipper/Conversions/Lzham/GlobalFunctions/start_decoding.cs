using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?start_decoding@symbol_codec@lzham@@QEAA_NPEBE_K_NP6AX1PEAXAEAPEBEAEA_KAEA_N@Z3@Z")]
[DemangledName("public: bool __cdecl lzham::symbol_codec::start_decoding(unsigned char const *, unsigned __int64, bool, void (__cdecl *)(unsigned __int64, void *, unsigned char const *&, unsigned __int64 &, bool &), void *)")]
internal static partial class start_decoding
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("unsigned char const *")] void* pBuf, [NativeType("unsigned __int64")] long buf_size, [NativeType("bool")] bool eof_flag, [NativeType("void (__cdecl *)(unsigned __int64, void *, unsigned char const *&, unsigned __int64 &, bool &)")] void* pNeed_bytes_func, [NativeType("void *")] void* pPrivate_data)
	{
		sbyte b = (eof_flag ? ((sbyte)1) : ((sbyte)0));
		if (buf_size == 0L)
		{
			return false;
		}
		unchecked
		{
			((lzham_symbol_codec*)@this)->m_total_model_updates = 0;
			((lzham_symbol_codec*)@this)->m_pDecode_buf = pBuf;
			((lzham_symbol_codec*)@this)->m_pDecode_buf_next = pBuf;
			((lzham_symbol_codec*)@this)->m_decode_buf_size = buf_size;
			((lzham_symbol_codec*)@this)->m_pDecode_buf_end = (byte*)pBuf + buf_size;
			((lzham_symbol_codec*)@this)->m_pDecode_need_bytes_func = pNeed_bytes_func;
			((lzham_symbol_codec*)@this)->m_pDecode_private_data = pPrivate_data;
			((lzham_symbol_codec*)@this)->m_decode_buf_eof = (((b & 1) == 1) ? ((sbyte)1) : ((sbyte)0));
			((lzham_symbol_codec*)@this)->m_bit_buf = 0L;
			((lzham_symbol_codec*)@this)->m_bit_count = 0;
			((lzham_symbol_codec*)@this)->m_mode = 2;
			return true;
		}
	}
}
