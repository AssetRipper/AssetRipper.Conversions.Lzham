using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?get_src_adler32@lzcompressor@lzham@@QEBAIXZ")]
[DemangledName("public: unsigned int __cdecl lzham::lzcompressor::get_src_adler32(void) const")]
internal static partial class Get_src_adler32
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke(void* @this)
	{
		return unchecked((lzham_lzcompressor*)@this)->field_4;
	}
}
