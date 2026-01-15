using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??A?$vector@Ulzdecision@lzcompressor@lzham@@@lzham@@QEBAAEBUlzdecision@lzcompressor@1@I@Z")]
[DemangledName("public: struct lzham::lzcompressor::lzdecision const & __cdecl lzham::vector<struct lzham::lzcompressor::lzdecision>::operator[](unsigned int) const")]
internal static partial class vector_struct_lzham_lzcompressor_lzdecision_Operator
{
	[return: NativeType("struct lzham::lzcompressor::lzdecision const &")]
	public unsafe static void* Invoke(void* @this, [NativeType("unsigned int")] int i)
	{
		return unchecked((byte*)((lzham_vector*)@this)->m_p + (nint)(uint)i * (nint)sizeof(lzham_CLZDecompBase));
	}
}
