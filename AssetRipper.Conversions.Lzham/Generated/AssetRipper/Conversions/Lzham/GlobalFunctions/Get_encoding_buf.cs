using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?get_encoding_buf@symbol_codec@lzham@@QEAAAEAV?$vector@E@2@XZ")]
[DemangledName("public: class lzham::vector<unsigned char> & __cdecl lzham::symbol_codec::get_encoding_buf(void)")]
internal static partial class Get_encoding_buf
{
	[return: NativeType("class lzham::vector<unsigned char> &")]
	public unsafe static void* Invoke(void* @this)
	{
		return &unchecked((lzham_symbol_codec*)@this)->m_output_buf;
	}
}
