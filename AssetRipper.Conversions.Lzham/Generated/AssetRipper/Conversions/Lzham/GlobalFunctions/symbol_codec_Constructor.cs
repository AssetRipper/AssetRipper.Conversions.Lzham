using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??0symbol_codec@lzham@@QEAA@XZ")]
[DemangledName("public: __cdecl lzham::symbol_codec::symbol_codec(void)")]
internal static partial class symbol_codec_Constructor
{
	public unsafe static void* Invoke(void* @this)
	{
		unchecked
		{
			lzham_vector* output_buf = &((lzham_symbol_codec*)@this)->m_output_buf;
			vector_unsigned_char_Constructor.Invoke(output_buf);
			lzham_vector* arith_output_buf = &((lzham_symbol_codec*)@this)->m_arith_output_buf;
			vector_unsigned_char_Constructor.Invoke(arith_output_buf);
			if (ExceptionInfo.Current == null)
			{
				lzham_vector* output_syms = &((lzham_symbol_codec*)@this)->m_output_syms;
				vector_struct_lzham_symbol_codec_output_symbol_Constructor.Invoke(output_syms);
				if (ExceptionInfo.Current == null)
				{
					clear_sksy5s.Invoke(@this);
					if (ExceptionInfo.Current == null)
					{
						return @this;
					}
					ExceptionInfo current = ExceptionInfo.Current;
					ExceptionInfo.Current = null;
					vector_struct_lzham_symbol_codec_output_symbol_Destructor.Invoke(output_syms);
					if (ExceptionInfo.Current != null)
					{
						return null;
					}
					ExceptionInfo.Current = current;
				}
				ExceptionInfo current2 = ExceptionInfo.Current;
				ExceptionInfo.Current = null;
				vector_unsigned_char_Destructor.Invoke(arith_output_buf);
				if (ExceptionInfo.Current != null)
				{
					return null;
				}
				ExceptionInfo.Current = current2;
			}
			ExceptionInfo current3 = ExceptionInfo.Current;
			ExceptionInfo.Current = null;
			vector_unsigned_char_Destructor.Invoke(output_buf);
			if (ExceptionInfo.Current != null)
			{
				return null;
			}
			ExceptionInfo.Current = current3;
			return null;
		}
	}
}
