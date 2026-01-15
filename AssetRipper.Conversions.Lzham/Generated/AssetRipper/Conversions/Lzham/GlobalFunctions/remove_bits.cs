using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?remove_bits@symbol_codec@lzham@@QEAAXI@Z")]
[DemangledName("public: void __cdecl lzham::symbol_codec::remove_bits(unsigned int)")]
internal static partial class remove_bits
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this, [NativeType("unsigned int")] int num_bits)
	{
		if (num_bits == 0)
		{
			return;
		}
		unchecked
		{
			while (((lzham_symbol_codec*)@this)->m_bit_count < num_bits)
			{
				int num = 0;
				if (((lzham_symbol_codec*)@this)->m_pDecode_buf_next == ((lzham_symbol_codec*)@this)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)@this)->m_decode_buf_eof & 1) != 1)
					{
						void* pDecode_need_bytes_func = ((lzham_symbol_codec*)@this)->m_pDecode_need_bytes_func;
						sbyte* decode_buf_eof = &((lzham_symbol_codec*)@this)->m_decode_buf_eof;
						long* decode_buf_size = &((lzham_symbol_codec*)@this)->m_decode_buf_size;
						void** pDecode_buf = &((lzham_symbol_codec*)@this)->m_pDecode_buf;
						void* pDecode_private_data = ((lzham_symbol_codec*)@this)->m_pDecode_private_data;
						((delegate*<long, void*, void**, long*, sbyte*, void>)pDecode_need_bytes_func)((long)((lzham_symbol_codec*)@this)->m_pDecode_buf_next - (long)((lzham_symbol_codec*)@this)->m_pDecode_buf, pDecode_private_data, pDecode_buf, decode_buf_size, decode_buf_eof);
						if (ExceptionInfo.Current != null)
						{
							return;
						}
						((lzham_symbol_codec*)@this)->m_pDecode_buf_end = (byte*)((lzham_symbol_codec*)@this)->m_pDecode_buf + ((lzham_symbol_codec*)@this)->m_decode_buf_size;
						((lzham_symbol_codec*)@this)->m_pDecode_buf_next = ((lzham_symbol_codec*)@this)->m_pDecode_buf;
						if (((lzham_symbol_codec*)@this)->m_pDecode_buf_next < ((lzham_symbol_codec*)@this)->m_pDecode_buf_end)
						{
							void** pDecode_buf_next = &((lzham_symbol_codec*)@this)->m_pDecode_buf_next;
							void* ptr = *pDecode_buf_next;
							*pDecode_buf_next = (byte*)ptr + 1;
							num = (byte)(*(sbyte*)ptr);
						}
					}
				}
				else
				{
					void** pDecode_buf_next2 = &((lzham_symbol_codec*)@this)->m_pDecode_buf_next;
					void* ptr2 = *pDecode_buf_next2;
					*pDecode_buf_next2 = (byte*)ptr2 + 1;
					num = (byte)(*(sbyte*)ptr2);
				}
				checked
				{
					unchecked((lzham_symbol_codec*)@this)->m_bit_count += 8;
				}
				long num2 = (long)((ulong)(uint)num << (int)(uint)checked(64 - unchecked((lzham_symbol_codec*)@this)->m_bit_count));
				((lzham_symbol_codec*)@this)->m_bit_buf |= num2;
			}
			((lzham_symbol_codec*)@this)->m_bit_buf <<= (int)(uint)num_bits;
			((lzham_symbol_codec*)@this)->m_bit_count -= num_bits;
		}
	}
}
