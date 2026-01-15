using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?decode_need_bytes@symbol_codec@lzham@@QEAAXXZ")]
[DemangledName("public: void __cdecl lzham::symbol_codec::decode_need_bytes(void)")]
internal static partial class decode_need_bytes
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			if ((((lzham_symbol_codec*)@this)->m_decode_buf_eof & 1) != 1)
			{
				void* pDecode_need_bytes_func = ((lzham_symbol_codec*)@this)->m_pDecode_need_bytes_func;
				sbyte* decode_buf_eof = &((lzham_symbol_codec*)@this)->m_decode_buf_eof;
				long* decode_buf_size = &((lzham_symbol_codec*)@this)->m_decode_buf_size;
				void** pDecode_buf = &((lzham_symbol_codec*)@this)->m_pDecode_buf;
				void* pDecode_private_data = ((lzham_symbol_codec*)@this)->m_pDecode_private_data;
				((delegate*<long, void*, void**, long*, sbyte*, void>)pDecode_need_bytes_func)((long)((lzham_symbol_codec*)@this)->m_pDecode_buf_next - (long)((lzham_symbol_codec*)@this)->m_pDecode_buf, pDecode_private_data, pDecode_buf, decode_buf_size, decode_buf_eof);
				if (ExceptionInfo.Current == null)
				{
					((lzham_symbol_codec*)@this)->m_pDecode_buf_end = (byte*)((lzham_symbol_codec*)@this)->m_pDecode_buf + ((lzham_symbol_codec*)@this)->m_decode_buf_size;
					((lzham_symbol_codec*)@this)->m_pDecode_buf_next = ((lzham_symbol_codec*)@this)->m_pDecode_buf;
				}
			}
		}
	}
}
