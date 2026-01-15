using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??1symbol_codec@lzham@@QEAA@XZ")]
[DemangledName("public: __cdecl lzham::symbol_codec::~symbol_codec(void)")]
internal static partial class symbol_codec_Destructor
{
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			vector_struct_lzham_symbol_codec_output_symbol_Destructor.Invoke(&((lzham_symbol_codec*)@this)->m_output_syms);
			if (ExceptionInfo.Current == null)
			{
				vector_unsigned_char_Destructor.Invoke(&((lzham_symbol_codec*)@this)->m_arith_output_buf);
				if (ExceptionInfo.Current == null)
				{
					vector_unsigned_char_Destructor.Invoke(&((lzham_symbol_codec*)@this)->m_output_buf);
				}
			}
		}
	}
}
