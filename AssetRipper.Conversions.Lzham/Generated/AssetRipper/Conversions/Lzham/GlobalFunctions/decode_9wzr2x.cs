using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?decode@symbol_codec@lzham@@QEAAIAEAUquasi_adaptive_huffman_data_model@2@@Z")]
[DemangledName("public: unsigned int __cdecl lzham::symbol_codec::decode(struct lzham::quasi_adaptive_huffman_data_model &)")]
[CleanName("decode")]
internal static partial class decode_9wzr2x
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke(void* @this, [NativeType("struct lzham::quasi_adaptive_huffman_data_model &")] void* model)
	{
		unchecked
		{
			void* pDecode_tables = ((lzham_raw_quasi_adaptive_huffman_data_model*)model)->m_pDecode_tables;
			while (((lzham_symbol_codec*)@this)->m_bit_count < 56)
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
							return 0;
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
			int num3 = (int)((((lzham_symbol_codec*)@this)->m_bit_buf >>> 48) + 1L);
			int num5;
			int i;
			if ((uint)num3 <= (uint)((lzham_prefix_coding_decoder_tables*)pDecode_tables)->m_table_max_code)
			{
				int num4 = ((int*)((lzham_prefix_coding_decoder_tables*)pDecode_tables)->m_lookup)[((lzham_symbol_codec*)@this)->m_bit_buf >>> (int)(uint)(64 - ((lzham_prefix_coding_decoder_tables*)pDecode_tables)->m_table_bits)];
				num5 = num4 & 0xFFFF;
				i = num4 >>> 16;
			}
			else
			{
				for (i = ((lzham_prefix_coding_decoder_tables*)pDecode_tables)->m_decode_start_code_size; (uint)num3 > (uint)((int*)(&((lzham_prefix_coding_decoder_tables*)pDecode_tables)->m_max_codes))[(uint)(i - 1)]; i++)
				{
				}
				int num6;
				checked
				{
					num6 = unchecked(((int*)(&((lzham_prefix_coding_decoder_tables*)pDecode_tables)->m_val_ptrs))[(uint)(i - 1)]) + unchecked((int)(((lzham_symbol_codec*)@this)->m_bit_buf >>> (int)(uint)(64 - i)));
				}
				if ((uint)num6 >= (uint)((lzham_raw_quasi_adaptive_huffman_data_model*)model)->m_total_syms)
				{
					return 0;
				}
				num5 = (ushort)((short*)((lzham_prefix_coding_decoder_tables*)pDecode_tables)->m_sorted_symbol_order)[num6];
			}
			((lzham_symbol_codec*)@this)->m_bit_buf <<= (int)(uint)i;
			((lzham_symbol_codec*)@this)->m_bit_count -= i;
			int num7 = (ushort)(*(short*)vector_unsigned_short_Operator.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)model)->m_sym_freq, num5));
			*(short*)vector_unsigned_short_Operator.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)model)->m_sym_freq, num5) = (short)(num7 + 1);
			if ((((lzham_raw_quasi_adaptive_huffman_data_model*)model)->m_symbols_until_update += -1) == 0)
			{
				((lzham_symbol_codec*)@this)->m_total_model_updates++;
				update_tables.Invoke(model, -1, sym_freq_all_ones: false);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
			}
			return num5;
		}
	}
}
