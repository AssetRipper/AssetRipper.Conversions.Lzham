using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??0?$vector@Uoutput_symbol@symbol_codec@lzham@@@lzham@@QEAA@XZ")]
[DemangledName("public: __cdecl lzham::vector<struct lzham::symbol_codec::output_symbol>::vector<struct lzham::symbol_codec::output_symbol>(void)")]
internal static partial class vector_struct_lzham_symbol_codec_output_symbol_Constructor
{
	public unsafe static void* Invoke(void* @this)
	{
		unchecked
		{
			((lzham_vector*)@this)->m_p = null;
			((lzham_vector*)@this)->m_size = 0;
			((lzham_vector*)@this)->m_capacity = 0;
			return @this;
		}
	}
}
