using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?decode_set_input_buffer@symbol_codec@lzham@@QEAAXPEBE_K0_N@Z")]
[DemangledName("public: void __cdecl lzham::symbol_codec::decode_set_input_buffer(unsigned char const *, unsigned __int64, unsigned char const *, bool)")]
internal static partial class decode_set_input_buffer
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this, [NativeType("unsigned char const *")] void* pBuf, [NativeType("unsigned __int64")] long buf_size, [NativeType("unsigned char const *")] void* pBuf_next, [NativeType("bool")] bool eof_flag)
	{
		bool num = eof_flag;
		unchecked
		{
			((lzham_symbol_codec*)@this)->m_pDecode_buf = pBuf;
			((lzham_symbol_codec*)@this)->m_pDecode_buf_next = pBuf_next;
			((lzham_symbol_codec*)@this)->m_decode_buf_size = buf_size;
			((lzham_symbol_codec*)@this)->m_pDecode_buf_end = (byte*)pBuf + buf_size;
			((lzham_symbol_codec*)@this)->m_decode_buf_eof = ((((num ? 1u : 0u) & 1u) == 1) ? ((sbyte)1) : ((sbyte)0));
		}
	}
}
