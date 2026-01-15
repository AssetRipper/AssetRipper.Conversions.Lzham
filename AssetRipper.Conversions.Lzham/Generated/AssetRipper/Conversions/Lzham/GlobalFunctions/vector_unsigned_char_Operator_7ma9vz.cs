using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??A?$vector@E@lzham@@QEBAAEBEI@Z")]
[DemangledName("public: unsigned char const & __cdecl lzham::vector<unsigned char>::operator[](unsigned int) const")]
[CleanName("vector_unsigned_char_Operator")]
internal static partial class vector_unsigned_char_Operator_7ma9vz
{
	[return: NativeType("unsigned char const &")]
	public unsafe static void* Invoke(void* @this, [NativeType("unsigned int")] int i)
	{
		return unchecked((byte*)((lzham_vector*)@this)->m_p + (uint)i);
	}
}
