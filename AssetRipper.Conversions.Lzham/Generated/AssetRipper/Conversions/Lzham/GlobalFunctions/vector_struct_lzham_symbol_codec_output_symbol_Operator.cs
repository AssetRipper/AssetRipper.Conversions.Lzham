using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??A?$vector@Uoutput_symbol@symbol_codec@lzham@@@lzham@@QEAAAEAUoutput_symbol@symbol_codec@1@I@Z")]
[DemangledName("public: struct lzham::symbol_codec::output_symbol & __cdecl lzham::vector<struct lzham::symbol_codec::output_symbol>::operator[](unsigned int)")]
internal static partial class vector_struct_lzham_symbol_codec_output_symbol_Operator
{
	[return: NativeType("struct lzham::symbol_codec::output_symbol &")]
	public unsafe static void* Invoke(void* @this, [NativeType("unsigned int")] int i)
	{
		return unchecked((byte*)((lzham_vector*)@this)->m_p + (nint)(uint)i * (nint)sizeof(lzham_sym_freq));
	}
}
