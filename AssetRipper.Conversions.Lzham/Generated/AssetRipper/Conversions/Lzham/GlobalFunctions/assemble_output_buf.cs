using AssetRipper.Conversions.Lzham.GlobalVariables;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?assemble_output_buf@symbol_codec@lzham@@QEAA_NXZ")]
[DemangledName("public: bool __cdecl lzham::symbol_codec::assemble_output_buf(void)")]
internal static partial class assemble_output_buf
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this)
	{
		unchecked
		{
			((lzham_symbol_codec*)@this)->m_total_bits_written = 0;
			int num = 0;
			for (int i = 0; (uint)i < (uint)size_atskx2.Invoke(&((lzham_symbol_codec*)@this)->m_output_syms); i++)
			{
				void* ptr = vector_struct_lzham_symbol_codec_output_symbol_Operator.Invoke(&((lzham_symbol_codec*)@this)->m_output_syms, i);
				if (((lzham_sym_freq*)ptr)->m_left == -2)
				{
					bool flag = put_bits_align_to_byte.Invoke(@this);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					if (!flag)
					{
						return false;
					}
				}
				else if (((lzham_sym_freq*)ptr)->m_left == -3)
				{
					if (size_s5xcpk.Invoke(&((lzham_symbol_codec*)@this)->m_arith_output_buf) == 0)
					{
						continue;
					}
					((lzham_symbol_codec*)@this)->m_arith_length = -1;
					((lzham_symbol_codec*)@this)->m_arith_value = 0;
					for (int j = 0; (uint)j < 4u; j++)
					{
						int num2 = (byte)(*(sbyte*)vector_unsigned_char_Operator_apxfsu.Invoke(&((lzham_symbol_codec*)@this)->m_arith_output_buf, num++));
						((lzham_symbol_codec*)@this)->m_arith_value = (((lzham_symbol_codec*)@this)->m_arith_value << 8) | num2;
						bool flag2 = put_bits.Invoke(@this, num2, 8);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						if (!flag2)
						{
							return false;
						}
					}
				}
				else if (((lzham_sym_freq*)ptr)->m_left == -1)
				{
					if ((uint)((lzham_symbol_codec*)@this)->m_arith_length < 16777216u)
					{
						do
						{
							int num3 = (((uint)num < (uint)size_s5xcpk.Invoke(&((lzham_symbol_codec*)@this)->m_arith_output_buf)) ? ((byte)(*(sbyte*)vector_unsigned_char_Operator_apxfsu.Invoke(&((lzham_symbol_codec*)@this)->m_arith_output_buf, num++))) : 0);
							bool flag3 = put_bits.Invoke(@this, num3, 8);
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
							if (!flag3)
							{
								return false;
							}
							((lzham_symbol_codec*)@this)->m_arith_value = (((lzham_symbol_codec*)@this)->m_arith_value << 8) | num3;
						}
						while ((uint)(((lzham_symbol_codec*)@this)->m_arith_length <<= 8) < 16777216u);
					}
					int num4 = (ushort)((lzham_sym_freq*)ptr)->m_right * (((lzham_symbol_codec*)@this)->m_arith_length >>> 11);
					int num5 = (((uint)((lzham_symbol_codec*)@this)->m_arith_value >= (uint)num4) ? 1 : 0);
					if (num5 == 0)
					{
						((lzham_symbol_codec*)@this)->m_arith_length = num4;
					}
					else
					{
						((lzham_symbol_codec*)@this)->m_arith_value -= num4;
						((lzham_symbol_codec*)@this)->m_arith_length -= num4;
					}
					if (num5 != ((lzham_sym_freq*)ptr)->m_freq)
					{
						lzham_assert.Invoke(String_7hba9n.__pointer, String_ednjr4.__pointer, 1129);
					}
				}
				else
				{
					bool flag4 = put_bits.Invoke(num_bits: ((lzham_sym_freq*)ptr)->m_left, @this: @this, bits: ((lzham_sym_freq*)ptr)->m_freq);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					if (!flag4)
					{
						return false;
					}
				}
			}
			bool result = flush_bits.Invoke(@this);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			return result;
		}
	}
}
