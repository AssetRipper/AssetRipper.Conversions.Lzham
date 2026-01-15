using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?get_compressed_data@lzcompressor@lzham@@QEAAAEAV?$vector@E@2@XZ")]
[DemangledName("public: class lzham::vector<unsigned char> & __cdecl lzham::lzcompressor::get_compressed_data(void)")]
internal static partial class Get_compressed_data
{
	[return: NativeType("class lzham::vector<unsigned char> &")]
	public unsafe static void* Invoke(void* @this)
	{
		return &unchecked((lzham_lzcompressor*)@this)->field_9;
	}
}
