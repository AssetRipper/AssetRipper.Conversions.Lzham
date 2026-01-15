using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??A?$vector@Ulzpriced_decision@lzcompressor@lzham@@@lzham@@QEAAAEAUlzpriced_decision@lzcompressor@1@I@Z")]
[DemangledName("public: struct lzham::lzcompressor::lzpriced_decision & __cdecl lzham::vector<struct lzham::lzcompressor::lzpriced_decision>::operator[](unsigned int)")]
internal static partial class vector_struct_lzham_lzcompressor_lzpriced_decision_Operator
{
	[return: NativeType("struct lzham::lzcompressor::lzpriced_decision &")]
	public unsafe static void* Invoke(void* @this, [NativeType("unsigned int")] int i)
	{
		return unchecked((byte*)((lzham_vector*)@this)->m_p + (nint)(uint)i * (nint)sizeof(lzham_lzcompressor_lzpriced_decision));
	}
}
